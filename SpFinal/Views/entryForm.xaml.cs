using SpFinal.Models;
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
using Xamarin.Essentials;

namespace SpFinal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class entryForm : ContentPage
    {
        public entryForm()
        {
            InitializeComponent();
        }

        async void Enter_Clicked(object sender, EventArgs e)
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
            else if( int.Parse(DAge.Text) >= 1 && int.Parse(DAge.Text) <= 150)
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