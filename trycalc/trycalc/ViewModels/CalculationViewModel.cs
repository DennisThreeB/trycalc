using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using trycalc.Models;
using Xamarin.Forms;

namespace trycalc.ViewModels
{
    public class CalculationViewModel : BaseViewModel
    {

        #region ValueBet

        public CalculationViewModel(ValueBetModel item = null)
        {
            ValueBetData = item;
        }

        public ValueBetModel ValueBetData { get; set; }

        public async Task<string> CalculateValueBet(string bookieQuoteEntry, string estimatedProbabilityEntry)
        {
            try
            {
                ValueBetData.bookieQuote = double.Parse(bookieQuoteEntry);
                ValueBetData.estimatedProbability = int.Parse(estimatedProbabilityEntry);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            ValueBetData.valueBetValue = (ValueBetData.bookieQuote * ValueBetData.estimatedProbability) / 100;

            if (ValueBetData.valueBetValue > 1.00)
            {
                return "Congrats, it's a valuebet. Your result is " + ValueBetData.valueBetValue;
            }
            else
            {
                return "Oh no, it's not a valuebet. Your result is " + ValueBetData.valueBetValue;

            }
        }

        #endregion

        #region PoissonBet

        public CalculationViewModel(PoissonModel item = null)
        {
            PoissonBetData = item;
        }

        public PoissonModel PoissonBetData { get; set; }


        public async Task<string> CalculatePoissonBet(string avgGoalsHome, string avgGoalsAway)
        {
            PoissonBetData.avgGoalsHome = double.Parse(avgGoalsHome);
            PoissonBetData.avgGoalsAway = double.Parse(avgGoalsAway);

            PoissonBetData.zeroZeroProb = ((Math.Pow(PoissonBetData.avgGoalsHome, 0) / await fakultaet(0)) *
                                           Math.Exp(-PoissonBetData.avgGoalsHome) *
                                          (Math.Pow(PoissonBetData.avgGoalsAway, 0) / await fakultaet(0)) *
                                           Math.Exp(-PoissonBetData.avgGoalsAway)) * 100;

            PoissonBetData.oneZeroProb = ((Math.Pow(PoissonBetData.avgGoalsHome, 1) / await fakultaet(1)) *
                                           Math.Exp(-PoissonBetData.avgGoalsHome) *
                                          (Math.Pow(PoissonBetData.avgGoalsAway, 0) / await fakultaet(0)) *
                                           Math.Exp(-PoissonBetData.avgGoalsAway)) * 100;

            PoissonBetData.zeroOneProb = ((Math.Pow(PoissonBetData.avgGoalsHome, 0) / await fakultaet(0)) *
                                           Math.Exp(-PoissonBetData.avgGoalsHome) *
                                          (Math.Pow(PoissonBetData.avgGoalsAway, 1) / await fakultaet(1)) *
                                           Math.Exp(-PoissonBetData.avgGoalsAway)) * 100;

            PoissonBetData.oneOneProb = ((Math.Pow(PoissonBetData.avgGoalsHome, 1) / await fakultaet(1)) *
                                           Math.Exp(-PoissonBetData.avgGoalsHome) *
                                          (Math.Pow(PoissonBetData.avgGoalsAway, 1) / await fakultaet(1)) *
                                           Math.Exp(-PoissonBetData.avgGoalsAway)) * 100;

            PoissonBetData.twoZeroProb = ((Math.Pow(PoissonBetData.avgGoalsHome, 2) / await fakultaet(2)) *
                                         Math.Exp(-PoissonBetData.avgGoalsHome) *
                                         (Math.Pow(PoissonBetData.avgGoalsAway, 0) / await fakultaet(0)) *
                                         Math.Exp(-PoissonBetData.avgGoalsAway)) * 100;

            PoissonBetData.zeroTwoProb = ((Math.Pow(PoissonBetData.avgGoalsHome, 0) / await fakultaet(0)) *
                                         Math.Exp(-PoissonBetData.avgGoalsHome) *
                                         (Math.Pow(PoissonBetData.avgGoalsAway, 2) / await fakultaet(2)) *
                                         Math.Exp(-PoissonBetData.avgGoalsAway)) * 100;

            PoissonBetData.overTwoFiveProb = 100 - (PoissonBetData.zeroZeroProb + PoissonBetData.oneZeroProb +
                                             PoissonBetData.zeroOneProb + PoissonBetData.oneOneProb +
                                             PoissonBetData.twoZeroProb + PoissonBetData.zeroTwoProb);

            PoissonBetData.underTwoFiveProb = PoissonBetData.zeroZeroProb + PoissonBetData.oneZeroProb +
                                             PoissonBetData.zeroOneProb + PoissonBetData.oneOneProb +
                                             PoissonBetData.twoZeroProb + PoissonBetData.zeroTwoProb;

            return "Poisson says: \n"
                   + Math.Round(PoissonBetData.zeroZeroProb, 1) + "% probability to get a 0:0 \n"
                   + Math.Round(PoissonBetData.oneZeroProb, 1) + "% probability to get a 1:0 \n"
                   + Math.Round(PoissonBetData.zeroOneProb, 1) + "% probability to get a 0:1 \n"
                   + Math.Round(PoissonBetData.oneOneProb, 1) + "% probability to get a 1:1 \n"
                   + Math.Round(PoissonBetData.twoZeroProb, 1) + "% probability to get a 2:0 \n"
                   + Math.Round(PoissonBetData.zeroTwoProb, 1) + "% probability to get a 0:2 \n \n"
                   + Math.Round(PoissonBetData.overTwoFiveProb, 1) + "% probability to get over 2.5 goals \n"
                   + Math.Round(PoissonBetData.underTwoFiveProb, 1) + "% probability to get under 2.5 goals \n";

        }

        private async Task<double> fakultaet(int goals)
        {
            double ergebnis = 1;
            for (int i = 1; i <= goals; i++)
            {
                ergebnis *= i;
            }
            return ergebnis;
        }

        #endregion

        #region ProbabilityBet
        public CalculationViewModel(ProbabilityBetModel item = null)
        {
            ProbabilityBetData = item;
        }

        public ProbabilityBetModel ProbabilityBetData { get; set; }


        public async Task<string> CalculateProbabilityBet(string bookieHomeQuoteEntry, string bookieDrawQuoteEntry,
            string bookieAwayQuoteEntry)
        {
            try
            {
                ProbabilityBetData.homeQuote = double.Parse(bookieHomeQuoteEntry);
                ProbabilityBetData.drawQuote = double.Parse(bookieDrawQuoteEntry);
                ProbabilityBetData.awayQuote = double.Parse(bookieAwayQuoteEntry);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            ProbabilityBetData.homeProbability = (1 / ProbabilityBetData.homeQuote) * 100;
            ProbabilityBetData.drawProbability = (1 / ProbabilityBetData.drawQuote) * 100;
            ProbabilityBetData.awayProbability = (1 / ProbabilityBetData.awayQuote) * 100;

            return "The following probabilities represents the rate of what your bookie things" +
                   "\n Probability win home: " + Math.Round(ProbabilityBetData.homeProbability, 2) + "%" +
                   "\n Probability draw: " + Math.Round(ProbabilityBetData.drawProbability, 2) + "%" +
                   "\n Probability away home: " + Math.Round(ProbabilityBetData.awayProbability, 2) + "%";
        }
        #endregion

    }
}
