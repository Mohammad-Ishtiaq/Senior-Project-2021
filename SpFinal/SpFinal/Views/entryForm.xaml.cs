using SpFinal.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
            Navigation.ShowPopup(new warning()
            {

                IsLightDismissEnabled = false

            }); ;

            Navigation.PushAsync(new Dlistpage());

        }
    }
}