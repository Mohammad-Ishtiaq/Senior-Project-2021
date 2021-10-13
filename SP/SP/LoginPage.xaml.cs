using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SP.Datasets;
using SQLite;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<SignInInformation>();
                var info = conn.Table<SignInInformation>().ToList();

                userData.ItemsSource = info;
            }
        }

        void DeleteButton_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}