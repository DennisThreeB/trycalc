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
        public CalculationViewModel(ValueBetModel item = null)
        {
            ValueBetData = item;
        }
        
        public ValueBetModel ValueBetData { get; set; }

        public async Task<string>CalculateValueBet(string bookieQuoteEntry, string estimatedProbabilityEntry)
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

        public CalculationViewModel(ProbabilityBetModel item = null)
        {
            ProbabilityBetData = item;
        }

        public ProbabilityBetModel ProbabilityBetData { get; set; }


        public async Task<string>CalculateProbabilityBet(string bookieHomeQuoteEntry, string bookieDrawQuoteEntry, string bookieAwayQuoteEntry)
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

           return "Probability win home: " + Math.Round(ProbabilityBetData.homeProbability, 2) +"%"+ "\n Probability draw: " + Math.Round(ProbabilityBetData.drawProbability, 2) + "%" + "\n Probability away home: " + Math.Round(ProbabilityBetData.awayProbability, 2) + "%";
        }
    }
}
