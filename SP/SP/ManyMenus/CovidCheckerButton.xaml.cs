using Newtonsoft.Json;
using SP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;


namespace SP.ManyMenus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CovidCheckerButton : ContentPage
    {
        public ObservableCollection<Root> CovidData;
        Random locationBase = new Random();
        public CovidCheckerButton()
        {
            InitializeComponent();
            CovidData = new ObservableCollection<Root>();
            this.BindingContext = this;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            GetLocation();
        }
        private async void GetLocation()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                var placemarks = await Geocoding.GetPlacemarksAsync(location.Latitude, location.Longitude);
                if (placemarks != null)
                {
                    var country = placemarks.FirstOrDefault();
                    TxtCountry.Text = country.CountryName;
                    TxtCountryCode.Text = country.CountryCode;
                    TxtAdminArea.Text = country.AdminArea;
                    TxtSubArea.Text = country.SubAdminArea;
                    TxtSubLocality.Text = country.SubLocality;
                    await GetCovidDataByLocaion(location.Latitude, location.Longitude);
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private async Task GetCovidDataByLocaion(double lat, double lon)
        {
            Indicator.IsRunning = true;
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://webhooks.mongodb-stitch.com/api/client/v2.0/app/covid-19-qppza/service/REST-API/incoming_webhook/us_only?min_date=2020-04-27T00:00:00.000Z&max_date=2020-04-27T00:00:00.000Z&hide_fields=_id,%20date,%20USA,%20NewYork,%20fips,%20uid");
            var responce = JsonConvert.DeserializeObject<List<Root>>(response);
            foreach (var item in responce)
            {
                CovidData.Add(item);
            }
            ListData.ItemsSource = CovidData;
            Indicator.IsRunning = false;
            Indicator.IsVisible = false;
            List<int> det = new List<int>();
            foreach (var item in CovidData)
            {
                det.Add(item.deaths);
            }
            var detData = det.Count;
            int val  = locationBase.Next(detData);
            TxtDeaths.Text = val.ToString();
            List<int> Con = new List<int>();
            foreach (var item in CovidData)
            {
                Con.Add(item.confirmed);
            }
            var conData = det.Count;
            int val1 = locationBase.Next(conData);
            TxtConfirmed.Text = val1.ToString();
            List<int> daily = new List<int>();
            foreach (var item in CovidData)
            {
                Con.Add(item.deaths_daily);
            }
            var dailyData = daily.Count;
            int val2 = locationBase.Next(conData);
            TxtDaily.Text = val2.ToString();
        }
    }
}