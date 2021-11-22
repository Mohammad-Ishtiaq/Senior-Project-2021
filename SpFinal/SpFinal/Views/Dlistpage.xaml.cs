using SpFinal.Models;
using SpFinal.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var mydetails = e.Item as DListModel;
            await Navigation.PushAsync(new DDescriptionPage(mydetails.DName, mydetails.DDescription, mydetails.DSymptoms, mydetails.MGender, mydetails.DAgeLow, mydetails.DAgeHigh));
        }
    }
}