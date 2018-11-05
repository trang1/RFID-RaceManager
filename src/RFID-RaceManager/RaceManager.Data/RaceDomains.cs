using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace RaceManager.Data
{
    public class Race
    {
        public int Id { get; set; }

        /// <summary>
        /// Minimum lap time, sec
        /// </summary>
        //public int MinLapTime { get; set; }

        public string Name { get; set; }
        public string Location { get; set; }
        public double? Length { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfLaps { get; set; }

        /// <summary>
        /// Number of qualification rounds
        /// </summary>
        public int NumberOfQualRounds { get; set; }
        //public int NumberOfFinals { get; set; }

        public List<Group> Groups { get; set; }
        public List<RaceEvent> RaceEvents { get; set; }

        [NotMapped]
        public bool Is18RoundEnabled { get; set; }

        public Race()
        {
            RaceEvents = new List<RaceEvent>();
        }
    }

    public class Group
    {
        public int Id { get; set; }
        public int RaceId { get; set; }
        public string Name { get; set; }
        public List<RacePilot> Pilots { get; set; }

        public Group()
        {
            Pilots = new List<RacePilot>();
        }
    }

    public class RaceEvent
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int RaceId { get; set; }
        public string Round { get; set; }
        public Group Group { get; set; }
        public List<LapsInfo> Laps { get; set; }

        public RaceEvent()
        {
            Laps = new List<LapsInfo>();
        }

        [NotMapped]
        public bool Finished { get; set; }
    }

    public class Pilot
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Team { get; set; }
        public string Email { get; set; }
        public int Confirmation { get; set; }

        [NotMapped]
        public string ConfirmationString
        {
            get { return Confirmation == 1 ? "Yes" : "No"; }
            set
            {
                if (string.IsNullOrEmpty(value)) return;

                if (value.ToLower() == "yes") Confirmation = 1;
                if (value.ToLower() == "no") Confirmation = 0;
            }
        }
    }

    [NotMapped]
    public class RacePilot : Pilot
    {
        public int GroupId { get; set; }
        public int OrderNumber { get; set; }
        public int IsChecked { get; set; }

        public RacePilot(Pilot pilot)
        {
            Id = pilot.Id;
            Name = pilot.Name;
            Nickname = pilot.Nickname;
            Team = pilot.Team;
            Email = pilot.Email;
            Tag = pilot.Tag;
            Confirmation = pilot.Confirmation;
        }

        public RacePilot()
        {
        }
    }

    public class LapsInfo
    {
        readonly TimeSpan DNS = TimeSpan.FromMilliseconds(1);
        readonly TimeSpan DNF = TimeSpan.FromMilliseconds(2);

        public int Id { get; set; }
        public int PilotId { get; set; }
        public string PilotName { get; set; }
        public int RaceEventId { get; set; }
        public int OrderNumber { get; set; }
        public int RankNumber { get; set; }
        public string Epc { get; set; }
        public string Pc { get; set; }
        public int IdCount { get; set; }
        public string Rssi { get; set; }
        public string CarrFrequency { get; set; }

        [NotMapped]
        public TimeSpan? StartTime { get; set; }

        private readonly TimeSpan?[] _lapsTime = { null, null, null, null, null, null };

        public List<TimeSpan> GetLapsTime()
        {
            return _lapsTime.Where(l => l.HasValue && l != TimeSpan.Zero && l != DNS && l != DNF).Select(l => l.Value).ToList();
        }

        public int LapsCount => _lapsTime.Count(l => l.HasValue);
        public int RegisteredLapsCount => _lapsTime.Count(l => l.HasValue && l != TimeSpan.Zero && l != DNS && l != DNF);

        public string Lap1
        {
            get { return GetLapTime(0); }
            set { SetLapTime(0, value); }
        }
        
        public string Lap2
        {
            get { return GetLapTime(1); }
            set { SetLapTime(1, value); }
        }
        
        public string Lap3
        {
            get { return GetLapTime(2); }
            set { SetLapTime(2, value); }
        }
        
        public string Lap4
        {
            get { return GetLapTime(3); }
            set { SetLapTime(3, value); }
        }
        
        public string Lap5
        {
            get { return GetLapTime(4); }
            set { SetLapTime(4, value); }
        }
        
        public string Lap6
        {
            get { return GetLapTime(5); }
            set { SetLapTime(5, value); }
        }

        private void SetLapTime(int index, string value)
        {
            TimeSpan ts;
            
            // first check our string format
            if (TimeSpan.TryParseExact(value, new[] { @"mm\:ss\,fff",
                                                      @"mm\:ss\.fff",
                                                      @"m\:ss\.fff",
                                                      @"m\:ss\,fff",
                                                      @"ss\.fff",
                                                      @"ss\,fff",
                                                      @"s\.fff",
                                                      @"s\,fff"
                                                        }, CultureInfo.CurrentCulture, out ts)
                // then standard formats
                || TimeSpan.TryParse(value, out ts))
            {
                _lapsTime[index] = ts;
            }
            else
            {
                // check special cases
                if (string.Compare(value, "DNF", StringComparison.OrdinalIgnoreCase) == 0)
                    _lapsTime[index] = DNF;

                else if (string.Compare(value, "DNS", StringComparison.OrdinalIgnoreCase) == 0)
                    _lapsTime[index] = DNS;
                // no success
                else
                    _lapsTime[index] = null;
            }
        }

        private string GetLapTime(int index)
        {
            var value = _lapsTime[index];

            if (value == DNF) return "DNF";
            if (value == DNS) return "DNS";

            return value?.ToString(@"mm\:ss\,fff");
        }

        public TimeSpan? BestLapTime
        {
            get
            {
                try
                {
                    var bestLapTimes = _lapsTime.Where(l => l.HasValue && l != TimeSpan.Zero && l != DNS && l != DNF);
                    return bestLapTimes.Min();
                }
                catch
                {
                    return null;
                }
            }
        }

        public string BestLapTimeString => BestLapTime?.ToString(@"mm\:ss\,fff");

        public TimeSpan? AvgLapTime
        {
            get
            {
                try
                {
                    var bestLapTimes = _lapsTime.Where(l => l.HasValue && l != TimeSpan.Zero && l != DNS && l != DNF)
                            .OrderBy(l => l.GetValueOrDefault(TimeSpan.MaxValue)).ToList();
                    if (bestLapTimes.Count < 3) return null;

                    return TimeSpan.FromMilliseconds(bestLapTimes.Take(3).Average(l => l.Value.TotalMilliseconds));
                }
                catch
                {
                    return null;
                }
            }
        }

        public double? AverageSpeed
        {
            get
            {
                if(!Length.HasValue) return null;

                var sum = TimeSpan.Zero;
                var count = 0;

                // average speed = n * Length / (LAP1 + ... LAPn)
                for (int i = 0; i < NumberOfLaps; i++)
                {
                    var lapTime = _lapsTime[i];
                    if (!lapTime.HasValue || lapTime == DNS || lapTime == DNF) continue;

                    sum += lapTime.Value;
                    count++;
                }

                return sum == TimeSpan.Zero ? null : (Length * count * 3.6 )/ sum.TotalSeconds;
            }
            set { }
        }

        public string TimeDifferential
        {
            get
            {
                var registeredLaps = GetLapsTime();
                if (registeredLaps.Count < 2) return null;
                
                var currentLapTime = registeredLaps.Last();
                var previousLapTime = registeredLaps[registeredLaps.Count - 2];

                return (currentLapTime - previousLapTime).ToString(@"mm\:ss\,fff");
            }
            set { }
        }
        
        public double? Distance { get; set; }
        public string Penalty { get; set; }

        // Length from the race properties
        [NotMapped]
        public double? Length { get; set; }

        // Number of laps from the race properties
        [NotMapped]
        public int NumberOfLaps { get; set; }

        public string AvgLapTimeString => AvgLapTime?.ToString(@"mm\:ss\,fff");
        public string AvgSpeedString => AverageSpeed?.ToString("F2");

        private TimeSpan _prevRaceTime = TimeSpan.Zero;

        public bool RegisterLapTime(TimeSpan raceTime, double minFirstLapTime, double minLapTime, string rssi, string carrFreq)
        {
            //if (_lapsTime == null) _lapsTime = new List<TimeSpan?>();

            var diff = raceTime - _prevRaceTime;
            IdCount++;
            Rssi = rssi;
            CarrFrequency = carrFreq;

            // For the first lap we need to compare time with another variable than next laps
            if (!StartTime.HasValue)
            {
                if (diff.TotalSeconds >= minFirstLapTime)
                    StartTime = diff;
                else
                {
                    Debug.WriteLine("Tag = " + Epc + ", diff = " + diff.TotalSeconds + ", skipping the first lap");
                    return false;
                }
            }
            else
            {
                if (diff.TotalSeconds >= minLapTime)
                {
                    var prev = Array.IndexOf(_lapsTime, null);
                    _lapsTime[prev] = diff;
                }
                else
                {
                    Debug.WriteLine("Tag = " + Epc + ", diff = " + diff.TotalSeconds + ", skipping");
                    return false;
                }
            }

            _prevRaceTime = raceTime;
            return true;
        }
    }

    public class AvgTop3RankingItem
    {
        public string Epc { get; set; }
        public List<TimeSpan> LapsTime { get; set; }
        public string PilotName { get; set; }
        public int RankNumber { get; set; }

        public TimeSpan? AvgLapTime
        {
            get
            {
                if (LapsTime == null)
                    LapsTime = new List<TimeSpan>();

                var times = LapsTime.OrderBy(l => l);
                if (times.Count() < 3) return null;

                return TimeSpan.FromMilliseconds(times.Take(3).Average(l => l.TotalMilliseconds));
            }
        }

        public int RegisteredLapsCount => LapsTime.Count;

        public string AvgLapTimeString => AvgLapTime?.ToString(@"mm\:ss\,fff");
    }
}
