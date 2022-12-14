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
    public partial class UserPage : ContentPage
    {
        public UserPage()
        {
            InitializeComponent();
        }

        private void cmdDangNhap(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LogInPage());
        }

        private void cmdDangKy(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }
    }
}