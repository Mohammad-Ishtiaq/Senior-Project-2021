﻿using SpFinal.Models;
using SpFinal.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SpFinal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void symptomChecker_Clicked(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<PersonInfo>();
            }

            Navigation.PushAsync(new entryForm());
        }

        void covidTracker_Clicked(object sender, EventArgs e)
        {

        }
    }
}
