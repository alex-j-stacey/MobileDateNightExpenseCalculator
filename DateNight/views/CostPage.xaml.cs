﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DateNight.views
{
    public partial class CostPage : ContentPage
    {
        public CostPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            try { lblDisplay.Text = App.dateCalc.GetTotalCost(); }
            catch(Exception e)
            {
                lblDisplay.Text = "$0.00";
                DisplayAlert("Error", e.Message, "Ok");
            }
            
        }
    }
}
