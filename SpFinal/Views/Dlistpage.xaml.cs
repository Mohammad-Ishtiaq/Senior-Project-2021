using SpFinal.Models;
using SpFinal.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Diagnostics;

namespace SpFinal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dlistpage : ContentPage
    {
        public Dlistpage()
        {
            InitializeComponent();
            BindingContext = new DViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using(SQLiteConnection conn = new SQLiteConnection(App.FilePath))
            {

                var personinfo = conn.Table<PersonInfo>().ToList();

                if (personinfo[0].PSymptoms == null)
                {
                    personinfo[0].PSymptoms = " ";
                }

                //Turn User Symptoms from string to List of strings with an index
                List<string> PSBreakUp = personinfo[0].PSymptoms.Split(',').ToList();

                //Remove all unneccesary spaces from each index
                for (int i = 0; i < PSBreakUp.Count; i++)
                {
                    if (PSBreakUp[i].StartsWith(" "))
                    {
                        PSBreakUp[i] = PSBreakUp[i].Substring(1);
                    }

                    if (PSBreakUp[i].EndsWith(" "))
                    {
                        PSBreakUp[i] = PSBreakUp[i].TrimEnd(' ');
                    }
                }


                //Create a new object of type DViewModel
                DViewModel Dlist = new DViewModel();

                //Start ranked each element
                for (int i = 0; i < Dlist.DiseaseDetails.Count; i++)
                {
                    //Reset each diseases ranking
                    Dlist.DiseaseDetails[i].DRank = 0;
                    //Store each diseases symptoms in a string lsit
                    List<string> DDSplit = Dlist.DiseaseDetails[i].DSymptoms.Split(',').ToList();

                    for (int b = 0; b < DDSplit.Count; b++)
                    {
                        if (DDSplit[b].StartsWith(" "))
                        {
                            DDSplit[b] = DDSplit[b].Substring(1);
                        }

                        if (DDSplit[b].EndsWith(" "))
                        {
                            DDSplit[b] = DDSplit[b].TrimEnd(' ');
                        }
                    }

                    //First loop to loop through every item in DDsplit list
                    for (int j = 0; j < DDSplit.Count; j++)
                    {
                        int temp1 = DDSplit.Count;
                        //Second loop to loop through user inputed Symptoms
                        for (int o = 0; o < PSBreakUp.Count; o++)
                        {
                            //When ever we see that the user input matches the DDSplit
                            //We add the fractional location value of the symptom to the rank.
                            //Higher rank means that the disease is the best fit.
                            //Lower ranking means the disease is less likely
                            if (DDSplit[j].ToLower() == PSBreakUp[o].ToLower())
                            {
                                Dlist.DiseaseDetails[i].DRank = Dlist.DiseaseDetails[i].DRank + (1.0 / temp1);
                            }
                        }
                    }

                    if (Dlist.DiseaseDetails[i].DRank == 0.0)
                    {
                        Dlist.DiseaseDetails.RemoveAt(i);
                        i--;
                    }

                }

                //Enter refreshing state of disease list
                DisplayList.BeginRefresh();

                //List diseases based on ranks decending from 1 -> 0
                //If multiple diseases have the same rank, they will be ranked based
                //alphabetically.
                DisplayList.ItemsSource = Dlist.DiseaseDetails.OrderByDescending(i => i.DRank);

                //Exit refreshing state of disease list
                DisplayList.EndRefresh();

            }
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as DListModel;
            await Navigation.PushAsync(new DDescriptionPage(mydetails.DName, mydetails.DDescription, mydetails.DSymptoms, mydetails.MGender, mydetails.DAgeLow, mydetails.DAgeHigh));
        }

    }
}


/*
 * //Sort the Dlist in a decending manner based on the new rankings
                for (int i = 0; i < Dlist.DiseaseDetails.Count-1; i++)
                {
                    if (Dlist.DiseaseDetails[i].DRank > Dlist.DiseaseDetails[i+1].DRank)
                    {
                        var temp = Dlist.DiseaseDetails[i + 1];
                        Dlist.DiseaseDetails[i + 1] = Dlist.DiseaseDetails[i];
                        Dlist.DiseaseDetails[i] = temp;
                    }
                }
 */