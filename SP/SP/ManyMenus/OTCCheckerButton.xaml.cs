//We use "using SP.Models" because we want to be able to refrence our
//public data structure we built in that CS file.
using SP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SP.ManyMenus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OTCCheckerButton : ContentPage
    {
        public OTCCheckerButton()
        {
            InitializeComponent();
            //This allows the description page that pops up after clicking on an item in the list view to
            //source / pull information from this CS file. 
            BindingContext = new MyListPageViewModel();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //When something is tapped, all of its attributes are then saved to the variable "mydetails"
            //We can then use this to refrence the "MyListPageDetail" function from "MyListPageDetail.cs"
            //We then can populate the information on that template easily.
            var mydetails = e.Item as MyListModel;
            await Navigation.PushAsync(new MyListPageDetail(mydetails.Name, mydetails.Ingredients, mydetails.Image));
        }
    }
}