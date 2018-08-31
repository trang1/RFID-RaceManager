using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RaceManager.UI
{
    public class Race
    {
        /// <summary>
        /// Minimum lap time, sec
        /// </summary>
        public int MinLapTime { get; set; }

        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public PilotInfo Pilot1 { get; set; }
        public PilotInfo Pilot2 { get; set; }
        public PilotInfo Pilot3 { get; set; }
        public PilotInfo Pilot4 { get; set; }
    }

    public class PilotInfo
    {
        public string Tag { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public TimeSpan BestLapTime { get; set; }
        public TimeSpan AvgLapTime { get; set; }

        public List<LapInfo> Laps { get; set; }

        public PilotInfo()
        {
            Laps = new List<LapInfo>();
        }
    }

    public class LapInfo
    {
        public int Number { get; set; }
        public string Epc { get; set; }
        public string Pc { get; set; }
        public int IdentCount { get; set; }
        public string Rssi { get; set; }
        public decimal CarrFrequency { get; set; }
        public TimeSpan Time { get; set; }
    }
}
