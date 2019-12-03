using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trycalc.Models;
using trycalc.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace trycalc.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ValuePage : ContentPage
    {
        public CalculationViewModel _viewModel { get; set; }

        public ValuePage()
        {
            InitializeComponent();

            var item = new ValueBetModel();

            BindingContext = _viewModel = new CalculationViewModel(item);
        }

        private async void CalculateValueBetClicked(object sender, EventArgs e)
        {
            if (bookieQuoteEntry.Text == null | estimatedProbabilityEntry.Text == null)
            {
               await DisplayAlert("Oooops", "You have to add all values to calculate", "OK");
            }
            else
            {
                try
                {
                    ValueLabel.Text = await _viewModel.CalculateValueBet(bookieQuoteEntry.Text, estimatedProbabilityEntry.Text);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
            
        }
    }
}