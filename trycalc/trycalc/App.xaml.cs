﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using trycalc.Services;
using trycalc.Views;

namespace trycalc
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage()
            {
                BarBackgroundColor = Color.FromHex("#006600"),
                BarTextColor = Color.White
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
