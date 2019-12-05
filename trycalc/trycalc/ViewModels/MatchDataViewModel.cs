using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using trycalc.Models;

namespace trycalc.ViewModels
{
    public class MatchDataViewModel : BaseViewModel
    {
        public IList<MatchCardDataModel> MatchCardDataCollection { get; set; }

        public object SelectedItem { get; set; }

        public MatchDataViewModel()
        {
            MatchCardDataCollection = new List<MatchCardDataModel>();
            GenerateCardModel();
        }

        private void GenerateCardModel()
        {
            MatchCardDataCollection = new ObservableCollection<MatchCardDataModel>
            {
                new MatchCardDataModel
                {
                    homeLogo = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/67/Borussia_Dortmund_logo.svg/2000px-Borussia_Dortmund_logo.svg.png",
                    awayLogo = "https://upload.wikimedia.org/wikipedia/en/thumb/0/04/RB_Leipzig_2014_logo.svg/1200px-RB_Leipzig_2014_logo.svg.png",
                    homeTeam = "Borussia Dortmund",
                    awayTeam = "RB Leipzig",
                    matchTime = "06:30 PM",
                    homePlace = 1,
                    awayPlace = 5

                }, 
                new MatchCardDataModel
                {
                    homeLogo = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/67/Borussia_Dortmund_logo.svg/2000px-Borussia_Dortmund_logo.svg.png",
                    awayLogo = "https://upload.wikimedia.org/wikipedia/en/thumb/0/04/RB_Leipzig_2014_logo.svg/1200px-RB_Leipzig_2014_logo.svg.png",
                    homeTeam = "Borussia Dortmund",
                    awayTeam = "RB Leipzig",
                    matchTime = "06:30 PM",
                    homePlace = 1,
                    awayPlace = 5

                },
                new MatchCardDataModel
                {
                    homeLogo = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/67/Borussia_Dortmund_logo.svg/2000px-Borussia_Dortmund_logo.svg.png",
                    awayLogo = "https://upload.wikimedia.org/wikipedia/en/thumb/0/04/RB_Leipzig_2014_logo.svg/1200px-RB_Leipzig_2014_logo.svg.png",
                    homeTeam = "Borussia Dortmund",
                    awayTeam = "RB Leipzig",
                    matchTime = "06:30 PM",
                    homePlace = 1,
                    awayPlace = 5

                },
                new MatchCardDataModel
                {
                    homeLogo = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/67/Borussia_Dortmund_logo.svg/2000px-Borussia_Dortmund_logo.svg.png",
                    awayLogo = "https://upload.wikimedia.org/wikipedia/en/thumb/0/04/RB_Leipzig_2014_logo.svg/1200px-RB_Leipzig_2014_logo.svg.png",
                    homeTeam = "Borussia Dortmund",
                    awayTeam = "RB Leipzig",
                    matchTime = "06:30 PM",
                    homePlace = 1,
                    awayPlace = 5

                },
                new MatchCardDataModel
                {
                    homeLogo = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/67/Borussia_Dortmund_logo.svg/2000px-Borussia_Dortmund_logo.svg.png",
                    awayLogo = "https://upload.wikimedia.org/wikipedia/en/thumb/0/04/RB_Leipzig_2014_logo.svg/1200px-RB_Leipzig_2014_logo.svg.png",
                    homeTeam = "Borussia Dortmund",
                    awayTeam = "RB Leipzig",
                    matchTime = "06:30 PM",
                    homePlace = 1,
                    awayPlace = 5

                }
            };
        }
    }
}
