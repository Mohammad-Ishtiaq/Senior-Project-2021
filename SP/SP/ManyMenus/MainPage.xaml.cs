﻿using SP.ManyMenus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Each button event happenes when you click on the specific button.
        //This is the main page that appears when the app loads.
        
        public void SymptomCheckerButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new symptomChecker());
        }

        private void OTCCheckerButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OTCCheckerButton());
        }

        private void CovidCheckerButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CovidCheckerButton());
        }
    }
}