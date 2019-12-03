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
            PoissonLabel.Text = await _viewModel.CalculatePoissonBet(avgGoalsHome.Text, avgGoalsAway.Text);
        }
    }
}