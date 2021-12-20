using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpFinal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DDescriptionPage : ContentPage
    {

        CancellationTokenSource cts;

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
                var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                cts = new CancellationTokenSource();
                var location = await Geolocation.GetLocationAsync(request, cts.Token);

                if (location == null)
                {
                    location = await Geolocation.GetLocationAsync(new GeolocationRequest
                    {
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(30)
                    });

                }else if (location != null)
                {
                    await Browser.OpenAsync("https://www.google.com/maps/search/" + DName.Text + "+Doctor+near+me/@"+location.Latitude+","+location.Longitude, BrowserLaunchMode.SystemPreferred);
                }
            }
            catch (Exception)
            {
                await DisplayAlert("Warning", "There seems to be an issue loading location data. Please move to a location with service, wifi, or turn off airplane mode.", "OK");
            }
        }
    }
}