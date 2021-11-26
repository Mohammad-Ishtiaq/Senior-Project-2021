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
                conn.CreateTable<PersonInfo>();
                var personinfo = conn.Table<PersonInfo>().ToList();

                int age = personinfo[0].PAge;
                string gender = personinfo[0].PGender;
                string symptoms = personinfo[0].PSymptoms;

                if(symptoms == null)
                {
                    symptoms = " ";
                }

                var _container = BindingContext as DViewModel;
                DisplayList.BeginRefresh();

                DisplayList.ItemsSource = _container.DiseaseDetails.Where(i => i.DSymptoms.Contains(symptoms));

                DisplayList.EndRefresh();
            }
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as DListModel;
            await Navigation.PushAsync(new DDescriptionPage(mydetails.DName, mydetails.DDescription, mydetails.DSymptoms, mydetails.MGender, mydetails.DAgeLow, mydetails.DAgeHigh));
        }

        void DisplayList_ItemAppearing(object sender, ItemVisibilityEventArgs e)
        {
            var _container = BindingContext as DViewModel;
            DisplayList.BeginRefresh();

            DisplayList.EndRefresh();

        }
    }
}