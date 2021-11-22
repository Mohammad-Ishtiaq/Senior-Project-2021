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
    public partial class DDescriptionPage : ContentPage
    {
        public DDescriptionPage(string Name, string Description, string Symptoms, string MG, int AL, int AH)
        {
            InitializeComponent();
            DName.Text = Name;
            DDescripion.Text = "Disease Descrption: " + Description;
            DSymptoms.Text = "Disease Symptoms: " + Symptoms;
            MGender.Text = "Most commonly found in: " + MG;
            AgeRange.Text = "Ages " + AL + ", and up are effected the most.";

        }
    }
}