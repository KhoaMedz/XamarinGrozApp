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
    public partial class LogInPage : ContentPage
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void cmdDangKy(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }

        private void btnDangNhap(object sender, EventArgs e)
        {
            Database db = new Database();
            List<User> userList = new List<User>();
            userList = db.selectAllUser();
            bool flag = false;

            foreach(User user in userList)
            {
                if (user.email == entryEmail.Text.ToString() && user.matKhau == entryMatKhau.Text.ToString())
                {
                    flag = true;
                    Navigation.PushAsync(new LoginSuccessful());
                    break;
                }
            }

            if (flag == false)
                DisplayAlert("Thông Báo", "Sai thông tin đăng nhập !", "OK");

        }
    }
}