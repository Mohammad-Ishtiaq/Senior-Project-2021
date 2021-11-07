using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SP.ManyMenus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class warningpopup : Popup
    {
        public warningpopup()
        {
            InitializeComponent();
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            Dismiss(null);
            Navigation.PushAsync(new symptomChecker());
        }
    }
}