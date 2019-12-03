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
            ValueLabel.Text = await _viewModel.CalculateValueBet(bookieQuoteEntry.Text, estimatedProbabilityEntry.Text);
        }
    }
}