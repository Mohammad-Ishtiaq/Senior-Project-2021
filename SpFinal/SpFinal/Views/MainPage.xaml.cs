using SpFinal.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
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
            Navigation.PushAsync(new entryForm());
        }

        void covidTracker_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        void Admin_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new adminpanel()
            {

                IsLightDismissEnabled = true

            }); ;
        }
    }
}
