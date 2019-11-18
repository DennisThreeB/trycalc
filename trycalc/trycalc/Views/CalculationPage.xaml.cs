using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trycalc.Models;
using trycalc.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace trycalc.Views
{
    [DesignTimeVisible(false)]
    public partial class CalculationPage : ContentPage
    {

        public CalculationViewModel _viewModel { get; set; }

        public CalculationPage(CalculationViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = _viewModel = viewModel;
        }

        public CalculationPage()
        {
            InitializeComponent();

            var item = new ProbabilityBetModel();

            BindingContext = _viewModel = new CalculationViewModel(item);

            CalculationPicker.Items.Add("Value Bet");
            CalculationPicker.Items.Add("Probability Bet");
            CalculationPicker.Items.Add("Poisson");

        }

        private async void CalculateValueBetClicked(object sender, EventArgs e)
        {
            ValueLabel.Text = await _viewModel.CalculateValueBet(bookieQuoteEntry.Text, estimatedProbabilityEntry.Text);
        }
        
        private async void CalculateProbabilityBetClicked(object sender, EventArgs e)
        { 
            ProbabilityLabel.Text = await _viewModel.CalculateProbabilityBet(bookieHomeQuoteEntry.Text, bookieDrawQuoteEntry.Text, bookieAwayQuoteEntry.Text);
        }
    }
}