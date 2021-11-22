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

                    Navigation.PushAsync(new Dlistpage());
                }
            }
        }
    }
}