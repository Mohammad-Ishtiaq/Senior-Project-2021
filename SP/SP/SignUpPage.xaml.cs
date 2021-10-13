using SP.Datasets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        void SaveButton_Clicked(object sender, EventArgs e)
        {

            //When the button is pressed, the data entered will be added
            //to the database accordingly as strings
            SignInInformation info = new SignInInformation()
            {
                FirstName = FnameEntry.Text,
                LastName = LnameEntry.Text,
                Email = EmailEntry.Text,
                Age = AgeEntry.Text,
                Sex = SexEntry.Text
            };

            //Making a connection to the data base. This also prevents us from
            //having to write another fucntion to close it after it is done being used.
            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.FilePath))
            {
                conn.CreateTable<SignInInformation>();
                int rowAdded = conn.Insert(info);
            }

            Navigation.PushAsync(new MainPage());
        }
    }
}