using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SP.ManyMenus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DiseaseDetailPage : ContentPage
    {
        public DiseaseDetailPage()
        {
            InitializeComponent();
        }

        public async void FAD_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.google.com/search?q=Doctor+find+near+me&source=hp&ei=kE18YenVBZKgoASInrCACQ&iflsig=ALs-wAMAAAAAYXxboD_6m7JM8_MQgDcymSfPjp-eEwee&oq=%7B%7D+find+near+me&gs_lcp=Cgdnd3Mtd2l6EAMyCAgAEIAEEMkDMgUIABCSAzIFCAAQgAQyBQgAEIAEMgUIABCABDIFCAAQgAQyBQgAEIAEMgYIABAWEB4yBggAEBYQHjIGCAAQFhAeOhQILhCABBCxAxCDARDHARDRAxCTAjoRCC4QgAQQsQMQgwEQxwEQ0QM6CAgAELEDEIMBOggIABCABBCxAzoOCC4QgAQQsQMQxwEQowI6CwgAEIAEELEDEIMBOhEILhCABBCxAxCDARDHARCjAjoUCC4QgAQQsQMQgwEQxwEQowIQkwI6CwguEIAEEMcBEKMCOg4ILhCABBCxAxDHARDRAzoLCC4QsQMQxwEQowI6BQguEIAEOggILhCxAxCDAToICC4QgAQQsQNQrBJYtShg_SpoAXAAeACAAVGIAbMGkgECMTWYAQCgAQGwAQA&sclient=gws-wiz&ved=0ahUKEwjp3Y-0r_DzAhUSEIgKHQgPDJAQ4dUDCAk&uact=5", BrowserLaunchMode.SystemPreferred);
        }
    }
}