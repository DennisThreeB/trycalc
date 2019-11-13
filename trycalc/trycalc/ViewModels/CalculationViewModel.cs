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
            BetData = item;
        }
        
        public ValueBetModel BetData { get; set; }

        public async Task<string>CalculateValueBet(string bookieQuoteEntry, string estimatedProbabilityEntry)
        {
            BetData.bookieQuote = double.Parse(bookieQuoteEntry);
            BetData.estimatedProbability = int.Parse(estimatedProbabilityEntry);

            BetData.valueBetValue = (BetData.bookieQuote * BetData.estimatedProbability) / 100;


            if (BetData.valueBetValue > 1.00)
            {
                return "Congrats, it's a valuebet. Your result is " + BetData.valueBetValue;
            }
            else
            {
                return "Oh no, it's not a valuebet. Your result is " + BetData.valueBetValue;

            }

        }

    }
}
