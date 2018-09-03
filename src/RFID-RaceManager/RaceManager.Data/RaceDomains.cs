using System;
using System.Collections.Generic;
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
        public int MinLapTime { get; set; }

        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfLaps { get; set; }

        /// <summary>
        /// Number of qualification rounds
        /// </summary>
        public int NumberOfQualRounds { get; set; }
        public int NumberOfFinals { get; set; }

        public IList<string> Groups { get; set; }
    }

    public class RaceEvent
    {
        public int Id { get; set; }
        public int RaceId { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public IList<Pilot> Pilots { get; set; }
    }
    public class Pilot
    {
        public int Id { get; set; }
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public TimeSpan BestLapTime { get; set; }
        public TimeSpan AvgLapTime { get; set; }

        public List<LapInfo> Laps { get; set; }

        public Pilot()
        {
            Laps = new List<LapInfo>();
        }
    }

    public class LapInfo
    {
        public int PilotId { get; set; }
        public int RaceEventId { get; set; }
        public int Number { get; set; }
        public string Epc { get; set; }
        public string Pc { get; set; }
        public int IdentCount { get; set; }
        public string Rssi { get; set; }
        public decimal CarrFrequency { get; set; }
        public TimeSpan Time { get; set; }
    }
}
