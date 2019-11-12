using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace trycalc.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculationPage : ContentPage
    {
        public CalculationPage()
        {
            InitializeComponent();
        }

        private void CalculatePoissonClicked(object sender, EventArgs e)
        {

        }
    }
}