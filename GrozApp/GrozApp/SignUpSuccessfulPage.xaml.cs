using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GrozApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpSuccessfulPage : ContentPage
    {
        public SignUpSuccessfulPage()
        {
            InitializeComponent();
        }

        private void cmdVeTrangChu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}