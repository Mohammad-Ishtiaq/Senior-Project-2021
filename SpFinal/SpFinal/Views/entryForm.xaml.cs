using SpFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using SpFinal.Services;
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
            BindingContext = new StrudentsViewModel();
        }

        void enterButton_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new warning()
            {

                IsLightDismissEnabled = false

            }); ;

             Navigation.PushAsync(new Page1());
        }

        void Symptoms_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((FirstName.Text != null) && (LastName.Text != null) && (Age.Text != null) && (Sex.Text != null))
            {
                if ((int.Parse(Age.Text) >= 1) && (int.Parse(Age.Text) <= 150))
                {
                    if ((Sex.Text.ToLower() == "male") || (Sex.Text.ToLower() == "female"))
                    {
                        enterButton.IsVisible = true;
                    }
                }
            }
            else
            {
                enterButton.IsVisible = false;
            }
        }
    }
}