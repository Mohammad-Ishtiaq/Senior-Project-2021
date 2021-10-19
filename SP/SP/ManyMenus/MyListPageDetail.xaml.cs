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
    public partial class MyListPageDetail : ContentPage
    {
        //We want to source the information for the speecic spots we designated in the XAML file.
        //We created a function which takes 3 inputs and gets the information
        public MyListPageDetail(string name, string Ingredients, string source)
        {
            InitializeComponent();

            MyItemNameShow.Text = name;
            MyIngrediantItemShow.Text = Ingredients;
            MyImageCall.Source = new UriImageSource()
            {
                Uri = new Uri(source)
            };

        }
    }
}
