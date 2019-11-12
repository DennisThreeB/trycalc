using System;
using System.ComponentModel;
using trycalc.Models;
using trycalc.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace trycalc.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        public async void StrategieItemClicked(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as CardDataModel;
            if (item == null)
            {
                return;
            }
            await Navigation.PushModalAsync(new StrategieDetailPage(new StrategieDetailViewModel(item)));

            //deselect item
            StrategieListView.SelectedItem = null;
        }
    }
}