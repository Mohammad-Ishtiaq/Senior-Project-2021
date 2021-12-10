﻿using SpFinal.Models;
using SpFinal.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;


namespace SpFinal.Views
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class entryForm : ContentPage
    {
        ObservableCollection<string> symptoms = new ObservableCollection<string>();
        public entryForm()
        {
            InitializeComponent();
            ListOfSymptoms();
        }
        public async void ListOfSymptoms()
        {
            try
            {
                symptoms.Add("Cough");
                symptoms.Add("Headache");
                symptoms.Add("Fever");
            }
            catch (Exception ex)
            {
                await DisplayAlert("", "" + ex, "Ok");
            }
        }
        private void DSymptom_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            symptomListView.IsVisible = true;
            symptomListView.BeginRefresh();

            try
            {
                var dataEmpty = symptoms.Where(i => i.ToLower().Contains(e.NewTextValue.ToLower()));

                if (string.IsNullOrWhiteSpace(e.NewTextValue))
                    symptomListView.IsVisible = false;
                else if (dataEmpty.Max().Length == 0)
                    symptomListView.IsVisible = false;
                else
                    symptomListView.ItemsSource = dataEmpty.Where(i => i.ToLower().Contains(e.NewTextValue.ToLower()));
            }
            catch
            {
                symptomListView.IsVisible = false;
            }
            symptomListView.EndRefresh();
        }
        private void ListView_OnItemTapped(Object sender, ItemTappedEventArgs e)
        {
            String listsd = e.Item as string;
            //
            //string input = DSymptoms.Text;
            //if (regex.IsMatch(input))
               // DSymptoms.Text = input.Substring(0, input.LastIndexOf(',')) + ", "+ listsd +", ";
            //else
               DSymptoms.Text = listsd + ", ";
            symptomListView.IsVisible = false;

            ((ListView)sender).SelectedItem = null;
        }
        void Enter_Clicked(object sender, EventArgs e)
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
                Navigation.ShowPopup(new warning()
                {

                    IsLightDismissEnabled = false

                }); ;
            }
            else if( int.Parse(DAge.Text) >= 1 && int.Parse(DAge.Text) <= 150)
            {
                if (MGender.Text == null)
                {
                    Navigation.ShowPopup(new warning()
                    {

                        IsLightDismissEnabled = false

                    }); ;
                }
                else if (MGender.Text.ToUpper() == "MALE" || MGender.Text.ToUpper() == "FEMALE")
                {
                    Navigation.ShowPopup(new warning()
                    {

                        IsLightDismissEnabled = false

                    }); ;

                    PersonInfo personinfo = new PersonInfo()
                    {
                        PAge = int.Parse(DAge.Text),
                        PGender = MGender.Text,
                        PSymptoms = DSymptoms.Text //new List<string>(DSymptom.Text.Split(','))
                    };

                    using(SQLiteConnection conn = new SQLiteConnection(App.FilePath))
                    {
                        conn.DeleteAll<PersonInfo>();
                        conn.CreateTable<PersonInfo>();
                        int rowsAdded = conn.Insert(personinfo);
                    }



                    Navigation.PushAsync(new Dlistpage());
                }
            }
        }
    }
}