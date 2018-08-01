using System;
using System.Collections.Generic;
using static Tracker.Business.Entities.Enums;

namespace Tracker.Business.Entities
{
    public class Athlete
    {
        public int AthleteID { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int MyProperty { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Gender Gender { get; set; }

        public Event AthleteEvent { get; set; }
        public AtheleteEvent Event { get; set; }
        public List<AthleteTestScore> Scores { get; set; }
        

    }
}
