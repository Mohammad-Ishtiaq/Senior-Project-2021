using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpFinal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DDescriptionPage : ContentPage
    {

        public DDescriptionPage(string Name, string Description, string Symptoms, string MG, int AL, int AH)
        {
            InitializeComponent();
            DName.Text = Name;
            DDescripion.Text = "Disease Descrption: " + Description;
            DSymptoms.Text = "Disease Symptoms: " + Symptoms;
            MGender.Text = "Most commonly found in: " + MG;
            AgeRange.Text = "Ages " + AL + ", and up are effected the most.";

        }

        private async void Doctor_Clicked(object sender, EventArgs e)
        {
            try
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
                if (location == null)
                {
                    Debug.WriteLine("NO GPS");
                }

                if (location != null)
                {
                    Browser.OpenAsync("https://www.google.com/maps/search/" + DName.Text + "+Doctor+near+me/@"+location.Latitude+","+location.Longitude, BrowserLaunchMode.SystemPreferred);
                }
            }
            catch (Exception)
            {
                Debug.WriteLine("IT NO WORK");
            }
        }
    }
}