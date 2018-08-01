using System;
using System.Collections.Generic;
using System.Text;
using static Tracker.Business.Entities.Enums;

namespace Tracker.Business.Entities
{
    public class AthleteTestScore
    {

        public int AthleteID { get; set; }
        public AthleteTest Test { get; set; }
        public double Score { get; set; }
    }
}
