using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SP.ManyMenus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Questionare : ContentPage
    {
        public Questionare()
        {
            InitializeComponent();
        }


        void enterButton_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new warningpopup()
            {
                IsLightDismissEnabled = false
            });

            Navigation.PushAsync(new DiseaseDetailPage());
        }

        void covidChecker_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CovidCheckerButton());
        }
    }
}