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
            }
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as DListModel;
            await Navigation.PushAsync(new DDescriptionPage(mydetails.DName, mydetails.DDescription, mydetails.DSymptoms, mydetails.MGender, mydetails.DAgeLow, mydetails.DAgeHigh));
        }
    }
}