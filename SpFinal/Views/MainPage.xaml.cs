using SpFinal.ManyMenus;
using SpFinal.Models;
using SpFinal.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
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
            /*
            When the "Symptom Checker" button is clicked
            we make a connection to the Sqlite Nuget package to 
            create a new database with a specific name.

            What the function down below does is create a connection which
            will automatically close once the user has navigated to a diffrent page.
            This prevents issues of reading and writing to a database that was left open
            and never closed.

            The FilePath is created in the
            Senior-Project-2021\SpFinal\SpFinal.Android\MainActivity.cs
            &
            Senior-Project-2021\SpFinal\SpFinal.iOS\AppDelegate.cs

            We are creating the table in this process because there were issues
            later on in the code because we were deleting a non-existant 
            database. The process take up a minisqual amount of time, so it
            does not effect the preformance of the application.
             */

            using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<PersonInfo>();
            }


            /*
             * We are using Navigation.PushAsync because it will allow us to get
             * move between menus / screens easier.
             * It also generated a back button at the top of the screen which allows
             * user to easiely go between pages. (MVVM method)
             */
            Navigation.PushAsync(new entryForm());
        }

        private async void covidTracker_Clicked(object sender, EventArgs e)
        {
            var location = await Geolocation.GetLastKnownLocationAsync();

            if (location == null)
            {
                location = await Geolocation.GetLocationAsync(new GeolocationRequest
                {
                    DesiredAccuracy = GeolocationAccuracy.Medium,
                    Timeout = TimeSpan.FromSeconds(30)
                });

            }

            await this.Navigation.PushAsync(new CovidCheckerButton());
        }
    }
}
