using SQLite;
using System;
using Xamarin.Forms;
using SpFinal.Models;
using SpFinal.Views;
using Xamarin.CommunityToolkit.Extensions;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using Xamarin.Essentials;
using System.IO;
using System.Linq;

namespace SpFinal
{
    public partial class EntryFormPage : ContentPage
    {
        /// <summary>
        /// this is page for entry of person sympth and create a instance of ISpeechToText
        /// </summary>
        private ISpeechToText _speechRecongnitionInstance;
        int CountText = 1;
        const string Stop_Words_File = "StopWordFile.txt";
        public EntryFormPage()
        {
            InitializeComponent();
            CountText = 1;
            ///used DependencyService
            try
            {
                _speechRecongnitionInstance = DependencyService.Get<ISpeechToText>();
            }
            catch (Exception ex)
            {
                recon.Text = ex.Message;
            }

            //its used for subscribe ISpeechToText
            MessagingCenter.Subscribe<ISpeechToText, string>(this, "STT", (sender, args) =>
            {
                SpeechToTextFinalResultRecieved(args);
            });

            MessagingCenter.Subscribe<ISpeechToText>(this, "Final", (sender) =>
            {
                start.IsEnabled = true;
            });
            //its used for subscribe IMessageSender Final and return text speech to text and add in txt box
            MessagingCenter.Subscribe<IMessageSender, string>(this, "STT", (sender, args) =>
            {
                SpeechToTextFinalResultRecieved(args);
            });

        }
        /// <summary>
        /// this is the function used for adding text to text box used 
        /// </summary>
        /// <param name="args"></param>
        private void SpeechToTextFinalResultRecieved(string args)
        {
            if (CountText == 1)
            {
                DAge.Text = args;
                CountText++;
            }
            else if (CountText == 2)
            {
                MGender.Text = args;
                CountText++;
            }
            else if (CountText == 3)
            {
                var str = args;
                if (str != null)
                {
                    RemovedWord(str);
                }

                CountText++;
            }

        }
        int index = 0;
        private async void RemovedWord(string text)
        {
            try
            {
                using (var streem = await FileSystem.OpenAppPackageFileAsync(Stop_Words_File))
                {
                    using (var reader = new StreamReader(streem))
                    {
                        string word = await reader.ReadToEndAsync();
                        string[] vs = word.Split();
                        string[] speechText = text.Split();
                        foreach (var s in speechText)
                        {
                            if (!vs.Contains(s))
                            {
                                DSymptom.Text = DSymptom.Text + s + ",";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex.Message);
            }
        }
        //string[] vs = str.Split();
        //        foreach (var item in vs)
        //        {

        //            DSymptom.Text = DSymptom.Text + item + ",";
        //        }
        /// <summary>
        /// this is Clicked event for voice to text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Start_Clicked(object sender, EventArgs e)
        {
            //call the function StartSpeechToText
            try
            {
                if (CountText == 4)
                {
                    CountText = 1;
                    DSymptom.Text = "";
                    DAge.Text = "";
                    MGender.Text = "";
                    await DisplayAlert("Woring", "Kindly try again you have try more then requied data", "ok");
                }
                else
                {
                    _speechRecongnitionInstance.StartSpeechToText();
                }
            }
            catch (Exception ex)
            {
                recon.Text = ex.Message;
            }

            if (Device.RuntimePlatform == Device.iOS)
            {
                start.IsEnabled = false;
            }



        }
        /// <summary>
        /// This event used for Enter_Clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Enter_Clicked(object sender, EventArgs e)
        {
            /*
             *Here we are doing a simple type check.
             *1. We first check if the age that is entered is between 1 - 150.
             *      If this check is failed, the warning popup appears.
             * 
             *2. Then we check if the user enters a geder which matches "male" or "female"
             *      If this check is failed, the warning popup appears.
             *      
             *Once the checks are passed:
             *We make a new instance of PersonalInfo (Senior-Project-2021\SpFinal\SpFinal\Models\PersonInfo.cs)
             *PersonalInfo is the class or object which holds the information inputed by the user in the entry fourm.
             *
             *We make a connection to the Sqlite database like we did before.
             *We delete the existing DB entries in (PersonInfo):
             *  We do this because it ensures that at every instance of our application we
             *  only have 1 entry in the DB.
             *  This helps us make reading information much easier, faster, and accurate later
             *  on when we want to manipulate it.
             */

            if (DAge.Text == null)
            {
                await DisplayAlert("Warning", "Please enter an age between 1 and 150", "OK");
            }
            else if (int.Parse(DAge.Text) >= 1 && int.Parse(DAge.Text) <= 150)
            {
                if (MGender.Text == null)
                {
                    await DisplayAlert("Warning", "Please enter ethier Male or Female", "OK");
                }
                else if (MGender.Text.ToUpper() == "MALE" || MGender.Text.ToUpper() == "FEMALE")
                {
                    if (DSymptom.Text == null && DSymptom.Text == "" && DSymptom.Text == " ")
                    {
                        await DisplayAlert("Warning", "Please enter at least 1 symptom", "OK");
                    }
                    else
                    {
                        Navigation.ShowPopup(new warning()
                        {

                            IsLightDismissEnabled = false

                        }); ;

                        PersonInfo personinfo = new PersonInfo()
                        {
                            PAge = int.Parse(DAge.Text),
                            PGender = MGender.Text,
                            PSymptoms = DSymptom.Text
                        };

                        using (SQLiteConnection conn = new SQLiteConnection(App.FilePath))
                        {
                            conn.DeleteAll<PersonInfo>();
                            conn.CreateTable<PersonInfo>();
                            int rowsAdded = conn.Insert(personinfo);
                        }

                        await Navigation.PushAsync(new Dlistpage());
                    }
                }
            }
        }
    }
}

