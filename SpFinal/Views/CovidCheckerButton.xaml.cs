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
        //private readonly string NewsUrl = "https://coronavirus-smartable.p.rapidapi.com/news/v1/";
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
            }
            catch (Exception)
            {
                TxtCountry.Text = "ERROR";
                TxtCountryCode.Text = "ERROR";
                TxtAdminArea.Text = "ERROR";
                TxtSubArea.Text = "ERROR";
                TxtSubLocality.Text = "ERROR";
                TxtConfirmed.Text = "ERROR";
                TxtDaily.Text = "ERROR";
            }

        }


        /// <summary>
        /// this function used for get cvid data from Covid Data api its get all record of covid in list
        /// </summary>
        /// <param name="AdminArea"></param>
        /// <returns></returns>
        private async Task GetCovidDataByLocaion(string AdminArea)
        {
            try
            {
                IsLoadind.IsVisible = true;
                IsLoadind.IsRunning = true;
                // Ceate a Http clinet for get data from server side 
                var httpClient = new HttpClient();
                //pass the url of api its return all covid data in json formate
                var response = await httpClient.GetStringAsync($"https://webhooks.mongodb-stitch.com/api/client/v2.0/app/covid-19-qppza/service/REST-API/incoming_webhook/us_only?state=New%20York&county=New%20York" + "&min_date=" + $"{YesterdayDate()}" + "&max_date=" + $"{TodayDate()}" + "&hide_fields=_id,%20date,%20USA,%20fips,%20uid");

                //Convert data json to text and parsing to our root model class
                var responce = JsonConvert.DeserializeObject<List<Root>>(response);
                //Used for each for filtring data by crunt location if is have record acording to the crunt location 
                foreach (var item in responce)
                {
                    //Cheak if country is == to TxtAdminArea and country == to  user TxtSubArea 
                    if (item.county == TxtAdminArea.Text || item.county == TxtSubArea.Text)
                    {
                        TxtConfirmed.Text = item.confirmed_daily.ToString();
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
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://coronavirus-smartable.p.rapidapi.com/news/v1/US/"),
                    Headers =
                        {
                            { "x-rapidapi-host", "coronavirus-smartable.p.rapidapi.com" },
                            { "x-rapidapi-key", "SIGN-UP-FOR-KEY" },
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


        string TodayDate()
        {
            string todayyear = DateTime.Now.Year.ToString();
            string todaymonth = DateTime.Now.Month.ToString();
            string todayday = (DateTime.Now.Day).ToString();
            string time = "00:00:00.000";

            switch (Convert.ToInt16(todaymonth))
            {
                case 1:
                    todaymonth = "01";
                    break;
                case 2:
                    todaymonth = "02";
                    break;
                case 3:
                    todaymonth = "03";
                    break;
                case 4:
                    todaymonth = "04";
                    break;
                case 5:
                    todaymonth = "05";
                    break;
                case 6:
                    todaymonth = "06";
                    break;
                case 7:
                    todaymonth = "07";
                    break;
                case 8:
                    todaymonth = "08";
                    break;
                case 9:
                    todaymonth = "09";
                    break;
                default:
                    break;
            }

            string todayDateForApi = $"{todayyear}-{todaymonth}-{todayday}T{time}Z";

            return todayDateForApi;
        }

        string YesterdayDate()
        {
            string todayyear = DateTime.Now.Year.ToString();
            string todaymonth = DateTime.Now.Month.ToString();
            string todayday = (DateTime.Now.Day-1).ToString();
            string time = "00:00:00.000";

            //Leap Year Checker
            if ((DateTime.Now.Year % 4) != 0)
            {
                int[] daysInMonthCheck = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                //Check if we need to move to the previous month because we are on the first date of the new month.
                if ((DateTime.Now.Day - 1) == 0)
                {
                    //Set the month back by 1
                    todaymonth = (DateTime.Now.Month - 1).ToString();

                    //Check if we are moving from january to december of the old year
                    if ((DateTime.Now.Month - 1) == 0)
                    {
                        //Set the month to decemeber
                        todaymonth = 12.ToString();
                    }

                    //Run a switch case to accurately display the previous months date.
                    //We use the array defined above to distinguse what was the last day in the month we are moving back too.
                    switch (DateTime.Now.Month - 1)
                    {
                        case 0: //December 31st of previous year
                            todayday = daysInMonthCheck[11].ToString();
                            todayyear = (DateTime.Now.Year - 1).ToString();
                            break;
                        case 1:
                            todayday = daysInMonthCheck[0].ToString();
                            break;
                        case 2:
                            todayday = daysInMonthCheck[1].ToString();
                            break;
                        case 3:
                            todayday = daysInMonthCheck[2].ToString();
                            break;
                        case 4:
                            todayday = daysInMonthCheck[3].ToString();
                            break;
                        case 5:
                            todayday = daysInMonthCheck[4].ToString();
                            break;
                        case 6:
                            todayday = daysInMonthCheck[5].ToString();
                            break;
                        case 7:
                            todayday = daysInMonthCheck[6].ToString();
                            break;
                        case 8:
                            todayday = daysInMonthCheck[7].ToString();
                            break;
                        case 9:
                            todayday = daysInMonthCheck[8].ToString();
                            break;
                        case 10:
                            todayday = daysInMonthCheck[9].ToString();
                            break;
                        case 11:
                            todayday = daysInMonthCheck[10].ToString();
                            break;
                        default:
                            break;
                    }
                }
            }
            else
            {
                int[] daysInMonthCheck = new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                //Check if we need to move to the previous month because we are on the first date of the new month.
                if ((DateTime.Now.Day - 1) == 0)
                {
                    //Set the month back by 1
                    todaymonth = (DateTime.Now.Month - 1).ToString();

                    //Check if we are moving from january to december of the old year
                    if ((DateTime.Now.Month - 1) == 0)
                    {
                        //Set the month to decemeber
                        todaymonth = 12.ToString();
                    }

                    //Run a switch case to accurately display the previous months date.
                    //We use the array defined above to distinguse what was the last day in the month we are moving back too.
                    switch (DateTime.Now.Month - 1)
                    {
                        case 0: //December 31st of previous year
                            todayday = daysInMonthCheck[11].ToString();
                            todayyear = (DateTime.Now.Year - 1).ToString();
                            break;
                        case 1:
                            todayday = daysInMonthCheck[0].ToString();
                            break;
                        case 2:
                            todayday = daysInMonthCheck[1].ToString();
                            break;
                        case 3:
                            todayday = daysInMonthCheck[2].ToString();
                            break;
                        case 4:
                            todayday = daysInMonthCheck[3].ToString();
                            break;
                        case 5:
                            todayday = daysInMonthCheck[4].ToString();
                            break;
                        case 6:
                            todayday = daysInMonthCheck[5].ToString();
                            break;
                        case 7:
                            todayday = daysInMonthCheck[6].ToString();
                            break;
                        case 8:
                            todayday = daysInMonthCheck[7].ToString();
                            break;
                        case 9:
                            todayday = daysInMonthCheck[8].ToString();
                            break;
                        case 10:
                            todayday = daysInMonthCheck[9].ToString();
                            break;
                        case 11:
                            todayday = daysInMonthCheck[10].ToString();
                            break;
                        default:
                            break;
                    }
                }

            }

            switch (Convert.ToInt16(todaymonth))
            {
                case 1:
                    todaymonth = "01";
                    break;
                case 2:
                    todaymonth = "02";
                    break;
                case 3:
                    todaymonth = "03";
                    break;
                case 4:
                    todaymonth = "04";
                    break;
                case 5:
                    todaymonth = "05";
                    break;
                case 6:
                    todaymonth = "06";
                    break;
                case 7:
                    todaymonth = "07";
                    break;
                case 8:
                    todaymonth = "08";
                    break;
                case 9:
                    todaymonth = "09";
                    break;
                default:
                    break;
            }

            string todayDateForApi = $"{todayyear}-{todaymonth}-{todayday}T{time}Z";

            return todayDateForApi;
        }

    }
}



/* COVID LIMITATION
 * The John hopkins api is limiting in the fact that the information that we request is not avalible everywhere. 
 * We can get the information for the specific state byt this causes issues when we want to be more precice like,
 * when we query for a specific sub-are (Kings County) for example. This sub-area does not exist in the database,
 * but New yor, New york (Manhattan) does.
 * 
 * Our Api can only give you information about new york accurately as of now due to this limitation.
 * 
 * 
 * "https://webhooks.mongodb-stitch.com/api/client/v2.0/app/covid-19-qppza/service/REST-API/incoming_webhook/us_only?state=" + $"{AdminArea}" + "&county=" + {County} + "&min_date=" + $"{yesterdayDate()}" + "&max_date=" + $"{todayDate()}" + "&hide_fields=_id,%20date,%20USA,%20fips,%20uid"
 * 
 * "https://webhooks.mongodb-stitch.com/api/client/v2.0/app/covid-19-qppza/service/REST-API/incoming_webhook/us_only?state=" + $"{AdminArea}" + "&min_date=" + $"{yesterdayDate()}" + "&max_date=" + $"{todayDate()}" + "&hide_fields=_id,%20date,%20USA,%20fips,%20uid"
 */