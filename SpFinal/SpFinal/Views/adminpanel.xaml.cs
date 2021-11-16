using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SpFinal.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class adminpanel : Popup
    {
        public adminpanel()
        {
            InitializeComponent();
        }
        
        void enter_Clicked(object sender, EventArgs e)
        {
            if (passwordenter.Text == "admin")
            {
                AdminMode.IsVisible = true;
            }
            else
            {
                Dismiss(null);
            }
        }
    }
}