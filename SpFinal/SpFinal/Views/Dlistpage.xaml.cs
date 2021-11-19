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
    }
}