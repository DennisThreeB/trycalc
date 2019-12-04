using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using trycalc.Models;
using Xamarin.Forms.Internals;

namespace trycalc.ViewModels
{
       public class CardDataViewModel : BaseViewModel
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
                        StrategieName = "Poisson Calculation",
                        StrategieDescription = "Bet under/over goals with this pretty nice probably calculator",
                        StrategieText = "The Poisson-Calculation is a pretty unknown way to calculate the probabilities for the results of a match. You need some statistiks to calculate it, but you will love to see how it works. For example i calculate a football match, we take a look at how many goals were made (average homegoals for hometeam, and the average awaygoals for the awayteam). These averages is what we need. You just have to fill the averages in our calculator and the calculator calculates the probability for any estimated result. You will get a table that shows you the probability for any result. At these probabilities you can see how many goals are estimated and you can place your bet based on this result."
                    },

                    new CardDataModel
                    {
                        StrategieAvatar = "StratPic.jpg",
                        StrategieName = "Value Bets",
                        StrategieDescription = "Be better than the bookie with value bets",
                        StrategieText = "A value bet is a bet where the probability of a given outcome is greater than the bookmakers odds reflect. Simply put, when value betting you will be placing bets that have a larger chance of winning than implied by the bookmakers odds. This means you will have an edge over the bookmaker in the long run. With our great calculator you can easily see when a bet is a valuebet. You will get great results over long time, you create your strategie and become a pro in earning money with bets."
                    },

                    new CardDataModel
                    {
                        StrategieAvatar = "StratPic.jpg",
                        StrategieName = "Probability Bets",
                        StrategieDescription = "Better knowledge of matchmaking? Try probability bets.",
                        StrategieText = "With calculating the probability, you can try to change your knowledge in money. With our Calculator you can see which probability the bookie sees for the match. It's a easy calculation, we only do 100% [BookiQuote]. For example: 100 % 1,50 = 66,7% (Homewin), 100 % 4,33 = 23,1% (Draw), 100 % 6,50 = 15,4% (Awaywin). If you think the hometeam will win with a probability of 75% or higher, you should bet on the hometeam. That's a pretty simple and easy way to get a better winrate in your bet history. Try it out"
                    },
                    
                    new CardDataModel
                    {
                        StrategieAvatar = "StratPic.jpg",
                        StrategieName = "Sure Bets",
                        StrategieDescription = "A nice way to make safe money, sure bets",
                        StrategieText = "Sure bets is a interesting way to make money. You need a lot of capital to get rich, but i want to show you this way of betting as well. Sure bets are bets where you will win for sure. Sound strange but its true. Finding these bets is pretty hard, because you have to check different platforms and compare the quotes. For example, you have a tennis match, on bookie A you get a 2.46 quote on homewin and on bookie B 1.87 quote on awaywin. If you bet 100$ on each, you will get a sure profit of 13.69%. We will try to get a partnership for this, to get these bets for you."
                    }
                };
                }
            }
        }
}
