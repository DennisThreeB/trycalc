using System;
using System.Collections.Generic;
using System.Text;

namespace trycalc.Models
{
    public class PoissonModel
    {
        public double avgGoalsHome { get; set; }
        public double avgGoalsAway { get; set; }
        public double zeroZeroProb { get; set; }
        public double oneZeroProb { get; set; }
        public double zeroOneProb { get; set; }
        public double oneOneProb { get; set; }
        public double twoZeroProb { get; set; }
        public double zeroTwoProb { get; set; }
        public double overTwoFiveProb { get; set; }
        public double underTwoFiveProb { get; set; }
    }
}
