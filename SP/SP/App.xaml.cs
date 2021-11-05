using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SP
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //This function is used to tell the program which page or menu to open at the start.
            //We switch from | MainPage = new MainPage() | to | MainPage = new NavigationPage(new MainPage()) | because this allows all
            //future pages to have a built in back button on the top left hand cornor.
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
