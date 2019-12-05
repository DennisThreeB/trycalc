using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace trycalc.Models
{
    public class MatchCardDataModel
    {
        public string homeTeam { get; set; }
        public string awayTeam { get; set; }
        public string matchTime { get; set; }
        public ImageSource homeLogo { get; set; }
        public ImageSource awayLogo { get; set; }
        public int homePlace { get; set; }
        public int awayPlace { get; set; }
    }
}
