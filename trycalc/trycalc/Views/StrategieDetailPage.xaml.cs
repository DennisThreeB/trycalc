﻿using System;
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
    public partial class StrategieDetailPage : ContentPage
    {
        private StrategieDetailViewModel _viewModel;
        public StrategieDetailPage(StrategieDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = _viewModel = viewModel;
        }

    }
}