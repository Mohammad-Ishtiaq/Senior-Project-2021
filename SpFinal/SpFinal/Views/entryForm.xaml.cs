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

namespace SpFinal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class entryForm : ContentPage
    {
        public entryForm()
        {
            InitializeComponent();
        }

        void Enter_Clicked(object sender, EventArgs e)
        {
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
                        PSymptoms = DSymptom.Text
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