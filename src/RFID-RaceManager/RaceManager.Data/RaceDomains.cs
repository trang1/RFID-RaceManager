using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
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
        public DateTime Date { get; set; }
        public int NumberOfLaps { get; set; }

        /// <summary>
        /// Number of qualification rounds
        /// </summary>
        public int NumberOfQualRounds { get; set; }
        //public int NumberOfFinals { get; set; }

        public List<Group> Groups { get; set; }
        public List<RaceEvent> RaceEvents { get; set; }

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
        public int RaceId { get; set; }
        public string Round { get; set; }
        public Group Group { get; set; }
        public List<LapsInfo> Laps { get; set; }

        public RaceEvent()
        {
            Laps = new List<LapsInfo>();
        }
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
        public decimal CarrFrequency { get; set; }

        [NotMapped]
        public TimeSpan? StartTime { get; set; }

        private readonly TimeSpan?[] _lapsTime = { null, null, null, null, null, null };

        public List<TimeSpan> GetLapsTime()
        {
            return _lapsTime.Where(l => l.HasValue && l != TimeSpan.Zero).Select(l => l.Value).ToList();
        }

        public int LapsCount => _lapsTime.Count(l => l.HasValue);
        [NotMapped]
        public string Lap1
        {
            get { return _lapsTime[0]?.ToString("g"); }
            set { SetLapTime(0, value); }
        }
        [NotMapped]
        public string Lap2
        {
            get { return _lapsTime[1]?.ToString("g"); }
            set { SetLapTime(1, value); }
        }
        [NotMapped]
        public string Lap3
        {
            get { return _lapsTime[2]?.ToString("g"); }
            set { SetLapTime(2, value); }
        }
        [NotMapped]
        public string Lap4
        {
            get { return _lapsTime[3]?.ToString("g"); }
            set { SetLapTime(3, value); }
        }
        [NotMapped]
        public string Lap5
        {
            get { return _lapsTime[4]?.ToString("g"); }
            set { SetLapTime(4, value); }
        }
        [NotMapped]
        public string Lap6
        {
            get { return _lapsTime[5]?.ToString("g"); }
            set { SetLapTime(5, value); }
        }

        private void SetLapTime(int index, string value)
        {
            TimeSpan ts;
            if (TimeSpan.TryParse(value, out ts))
            {
                _lapsTime[index] = ts;
            }
            else
                _lapsTime[index] = null;
        }

        public TimeSpan? BestLapTime
        {
            get
            {
                try
                {
                    var bestLapTimes = _lapsTime.Where(l => l.HasValue && l != TimeSpan.Zero);
                    return bestLapTimes.Min();
                }
                catch
                {
                    return null;
                }
            }
        }

        public string BestLapTimeString => BestLapTime?.ToString("g");

        public TimeSpan? AvgLapTime
        {
            get
            {
                try
                {
                    var bestLapTimes = _lapsTime.Where(l => l.HasValue && l != TimeSpan.Zero)
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
        public string AvgLapTimeString => AvgLapTime?.ToString("g");

        private TimeSpan _prevRaceTime = TimeSpan.Zero;

        public bool RegisterLapTime(TimeSpan raceTime, double minFirstLapTime, double minLapTime)
        {
            //if (_lapsTime == null) _lapsTime = new List<TimeSpan?>();

            var diff = raceTime - _prevRaceTime;
            IdCount++;

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
        public string AvgLapTimeString => AvgLapTime?.ToString("g");
    }
}
