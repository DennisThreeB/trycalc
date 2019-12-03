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
    public partial class PoissonPage : ContentPage
    {
        public CalculationViewModel _viewModel { get; set; }

       public PoissonPage()
        {
            InitializeComponent();
            var item = new PoissonModel();
            BindingContext = _viewModel = new CalculationViewModel(item);
        }
        private async void CalculatePoissonBetClicked(object sender, EventArgs e)
        {
            if (avgGoalsHome.Text == null | avgGoalsAway.Text == null)
            {
                await DisplayAlert("Oooops", "You have to add all values to calculate", "OK");
            }
            else
            {
                try
                {
                    PoissonLabel.Text = await _viewModel.CalculatePoissonBet(avgGoalsHome.Text, avgGoalsAway.Text);
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