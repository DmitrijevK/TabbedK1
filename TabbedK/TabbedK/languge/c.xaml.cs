using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedK.eöement
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class c : TabbedPage
    {
        public c()
        {
            InitializeComponent();
        }

        private async void KButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Hi", "Continue", "Stop");
        }
    }
}