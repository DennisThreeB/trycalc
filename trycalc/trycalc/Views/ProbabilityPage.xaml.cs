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
    public partial class ProbabilityPage : ContentPage
    {
        public CalculationViewModel _viewModel { get; set; }

        public ProbabilityPage()
        {
            InitializeComponent();

            var item = new ProbabilityBetModel();

            BindingContext = _viewModel = new CalculationViewModel(item);
        }
        private async void CalculateProbabilityBetClicked(object sender, EventArgs e)
        {
            ProbabilityLabel.Text = await _viewModel.CalculateProbabilityBet(bookieHomeQuoteEntry.Text, bookieDrawQuoteEntry.Text, bookieAwayQuoteEntry.Text);
        }
    }
}