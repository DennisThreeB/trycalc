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
                        StrategieText = "Beispieltext"
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
