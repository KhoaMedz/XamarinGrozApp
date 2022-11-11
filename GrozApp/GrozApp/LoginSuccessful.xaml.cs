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
    public partial class LoginSuccessful : ContentPage
    {
        public LoginSuccessful()
        {
            InitializeComponent();
        }

        private void cmdVeTrangChu(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}