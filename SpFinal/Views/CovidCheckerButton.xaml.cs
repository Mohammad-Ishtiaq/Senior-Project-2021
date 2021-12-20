using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;
using SpFinal.Models;
using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.Threading;

namespace SpFinal.ManyMenus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CovidCheckerButton : ContentPage
    {


        /// <summary>
        /// News url use for get news according to location its like path
        /// </summary>
        private readonly string NewsUrl = "https://coronavirus-smartable.p.rapidapi.com/news/v1/";
        CancellationTokenSource cts;
        // Create news propertiy for binding to front end 
        public ObservableCollection<News> News { get; set; }
        /// <summary>
        /// Conctroctore of this class
        /// </summary>
        public CovidCheckerButton()
        {
            InitializeComponent();
            // Create new object every time sdd new record in news 
            News = new ObservableCollection<News>();
            // Binding data to this page 
            this.BindingContext = this;
        }
        /// <summary>
        /// this function override for get crunt  location of user
        /// </summary>
        protected override void OnAppearing()
        {
            base.OnAppearing();
            GetLocation();
        }
        /// <summary>
        ///  Create funtion for location 
        /// </summary>
        private async void GetLocation()
        {
            // Get user crunt location atributes
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10));
                cts = new CancellationTokenSource();
                var location = await Geolocation.GetLocationAsync(request, cts.Token);

                if (location != null)
                {
                    //passed these parameter to this function and get all record like couuuntry ane province name location country code etx
                    var placemarks = await Geocoding.GetPlacemarksAsync(location.Latitude, location.Longitude);
                    Console.WriteLine(placemarks);
                    //cheach if is not null then add data to text boxs
                    if (placemarks != null)
                    {
                        //used c# and set oder 
                        var country = placemarks.FirstOrDefault();
                        TxtCountry.Text = country.CountryName;
                        TxtCountryCode.Text = country.CountryCode;
                        TxtAdminArea.Text = country.AdminArea;
                        TxtSubArea.Text = country.SubAdminArea;
                        TxtSubLocality.Text = country.SubLocality;
                        //Pass parameters to this function 
                        await GetCovidDataByLocaion(TxtAdminArea.Text);
                        // Used console for run time testing only its prenting in output 
                        Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                    }
                }
                else
                {
                    await DisplayAlert("Warning", "There seems to be an issue loading location data. Please move to a location with service, wifi, or turn off airplane mode.", "OK");
                }
            }
            catch (Exception)
            {
                await DisplayAlert("Warning", "There seems to be an issue loading location data. Please move to a location with service, wifi, or turn off airplane mode.", "OK");
            }
        }


        /// <summary>
        /// this function used for get cvid data from Covid Data api its get all record of covid in list
        /// </summary>
        /// <param name="AdminArea"></param>
        /// <returns></returns>
        private async Task GetCovidDataByLocaion(string AdminArea)
        {
            IsLoadind.IsVisible = true;
            IsLoadind.IsRunning = true;
            // Ceate a Http clinet for get data from server side 
            var httpClient = new HttpClient();
            //pass the url of api its return all covid data in json formate
            try
            {
                var response = await httpClient.GetStringAsync("https://webhooks.mongodb-stitch.com/api/client/v2.0/app/covid-19-qppza/service/REST-API/incoming_webhook/us_only?min_date=2020-04-27T00:00:00.000Z&max_date=2020-04-27T00:00:00.000Z&hide_fields=_id,%20date,%20USA,%20NewYork,%20fips,%20uid");


                //Convert data json to text and parsing to our root model class
                var responce = JsonConvert.DeserializeObject<List<Root>>(response);
                //Used for each for filtring data by crunt location if is have record acording to the crunt location 
                foreach (var item in responce)
                {
                    //Cheak if country is == to TxtAdminArea and country == to  user TxtSubArea 
                    if (item.county == TxtAdminArea.Text || item.county == TxtSubArea.Text)
                    {
                        TxtConfirmed.Text = item.confirmed.ToString();
                        TxtDeaths.Text = item.deaths.ToString();
                        TxtDaily.Text = item.deaths_daily.ToString();
                    }
                }
                //Get location function call
                GetAllCovidNewsByLocation();

            }
            catch (Exception)
            {
                await DisplayAlert("Warning", "There seems to be an issue loading location data. " +
                        "Please move to a location with service, wifi, or turn off airplane mode. " +
                        "Some information on this page will not load due to this error.", "OK");
                throw;
            }
            
        }

        protected override void OnDisappearing()
        {
            if (cts != null && !cts.IsCancellationRequested)
                cts.Cancel();
            base.OnDisappearing();
        }

        /// <summary>
        /// this function get all new from new api according to user crunt locatio like country etc
        /// </summary>
        private async void GetAllCovidNewsByLocation()
        {
            //Used try cath 
            try
            {
                /// string path for news api and pass country code 
                string url = "https://coronavirus-smartable.p.rapidapi.com/news/v1/" + TxtCountryCode.Text + "/";
                //create New http clint for get data from server for news api 
                var client = new HttpClient();
                //passed all requird parameters
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(url),
                    Headers =
                {
                        //host name 
                    { "x-rapidapi-host", "coronavirus-smartable.p.rapidapi.com" },
                    //Api key for access this api
                    { "x-rapidapi-key", "6864cea06cmshffe4319ec6332a8p1e21e6jsn8627414216ad" },
                },
                };
                // Send requiest to the servr 
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    //cheach is server return ok 
                    var body = await response.Content.ReadAsStringAsync();
                    // Convert Json to  text data data parsing json to required oject
                    var responce = JsonConvert.DeserializeObject<NewsRoot>(body);
                    Console.WriteLine(body);
                    // add all record in News using loop
                    foreach (var item in responce.news)
                    {
                        News.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }
            IsLoadind.IsVisible = false;
            IsLoadind.IsRunning = false;
        }
        /// <summary>
        /// This is tap event for the news details 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //Send record data to url
            var url = (sender as View).BindingContext as News;
            //Cheak if web url  null show massage
            if (url.ampWebUrl == null)
            {
                await DisplayAlert("Sorry!!", "Sorry this site not available try again Thanks!!", "Ok");
            }
            else
            {
                //if not null the gose to web  
                await Browser.OpenAsync(url.ampWebUrl);
            }

        }


    }
}