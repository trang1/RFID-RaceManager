using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

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
        public int NumberOfFinals { get; set; }

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
        public string Name { get; set; }
        public List<Pilot> Pilots { get; set; }

        public Group()
        {
            Pilots = new List<Pilot>();
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
        public int OrderNumber { get; set; }
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Team { get; set; }
        public string Email { get; set; }
        public bool Confirmation { get; set; }

        public string ConfirmationString => Confirmation ? "Yes" : "No";
    }

    public class LapsInfo
    {
        public int Id { get; set; }
        public int PilotId { get; set; }
        public string PilotName { get; set; }
        public int RaceEventId { get; set; }
        public int OrderNumber { get; set; }
        public string Epc { get; set; }
        public string Pc { get; set; }
        public int IdentCount { get; set; }
        public string Rssi { get; set; }
        public decimal CarrFrequency { get; set; }
        private List<TimeSpan?> LapsTime { get; set; }
        public string Lap1 => LapsTime?.ElementAtOrDefault(0, null)?.ToString("g");
        public string Lap2 => LapsTime?.ElementAtOrDefault(1, null)?.ToString("g");
        public string Lap3 => LapsTime?.ElementAtOrDefault(2, null)?.ToString("g");
        public string Lap4 => LapsTime?.ElementAtOrDefault(3, null)?.ToString("g");
        public string Lap5 => LapsTime?.ElementAtOrDefault(4, null)?.ToString("g");
        public string Lap6 => LapsTime?.ElementAtOrDefault(5, null)?.ToString("g");

        public TimeSpan? BestLapTime
        {
            get
            {
                try
                {
                    return LapsTime.Min();
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
                    return TimeSpan.FromMilliseconds(LapsTime.Average(l => l.Value.TotalMilliseconds));
                }
                catch
                {
                    return null;
                }
            }
        }
        public string AvgLapTimeString => AvgLapTime?.ToString("g");

        private TimeSpan _prevRaceTime = TimeSpan.Zero;

        public void RegisterLapTime(TimeSpan raceTime, double minLapTime)
        {
            if (LapsTime == null) LapsTime = new List<TimeSpan?>();

            var diff = raceTime - _prevRaceTime;

            if (diff.TotalSeconds >= minLapTime)
                LapsTime.Add(diff);
            else
            {
                Debug.WriteLine("Tag = " + Epc + ", diff = " + diff.TotalSeconds + ", skipping");
                return;
            }

            _prevRaceTime = raceTime;
        }
    }
}
