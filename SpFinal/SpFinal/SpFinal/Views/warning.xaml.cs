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
    public partial class warning : Popup
    {
        public warning()
        {
            InitializeComponent();
        }

        void agreed_Clicked(object sender, EventArgs e)
        {
            Dismiss(null);
        }
    }
}