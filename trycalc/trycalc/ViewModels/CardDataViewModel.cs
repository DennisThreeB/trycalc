using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using trycalc.Models;

namespace trycalc.ViewModels
{
        class CardDataViewModel
        {

            public IList<CardDataModel> CardDataCollection { get; set; }

            public object SelectedItem { get; set; }

            public CardDataViewModel()
            {
                CardDataCollection = new List<CardDataModel>();
                GenerateCardModel();
            }

            private void GenerateCardModel()
            {
                for (var i = 0; i < 10; i++)
                {
                    CardDataCollection = new ObservableCollection<CardDataModel>
                {
                    new CardDataModel
                    {
                        StrategieAvatar = "StratPic.jpg",
                        StrategieName = "Poisson Berechnung",
                        StrategieDescription = "Bet under/over goals with this pretty nice probably calculator",
                        StrategieText = "The Poisson-Calculation is a pretty unknown way to calculate the probabilities for the results of a match. You need some statistiks to calculate it, but you will love to see how it works. For example i calculate a football match, we take a look at how many goals were made (average homegoals for hometeam, and the average awaygoals for the awayteam). These averages is what we need. You just have to fill the averages in our calculator and the calculator calculates the probability for any estimated result. You will get a table that shows you the probability for any result. At these probabilities you can see how many goals are estimated and you can place your bet based on this result."
                    },

                    new CardDataModel
                    {
                        StrategieAvatar = "StratPic.jpg",
                        StrategieName = "Value Bets",
                        StrategieDescription = "Bet on any offer with value",
                        StrategieText = "Valuebets text"
                    },

                    new CardDataModel
                    {
                        StrategieAvatar = "StratPic.jpg",
                        StrategieName = "Probabilitybets",
                        StrategieDescription = "Calculate the probabilty of your game",
                        StrategieText = "Probabilitytext"
                    }
                };
                }
            }
        }
}
