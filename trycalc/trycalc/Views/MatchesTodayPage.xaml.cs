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
    public partial class MatchesTodayPage : ContentPage
    {
        public MatchesTodayPage()
        {
            InitializeComponent();
        }

        public async void MatchItemClicked(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as MatchCardDataModel;
            if (item == null)
            {
                return;
            }
           // await Navigation.PushModalAsync(new StrategieDetailPage(new StrategieDetailViewModel(item)));

            //deselect item
            TodaysMatchesListView.SelectedItem = null;
        }
    }
}