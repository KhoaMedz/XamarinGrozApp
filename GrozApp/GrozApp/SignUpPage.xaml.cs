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
    public partial class SignUpPage : ContentPage
    {
        User user = new User();
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void cmdDangNhap(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LogInPage());
        }

        private void cmdDangKy(object sender, EventArgs e)
        {
            try
            {
                Database db = new Database();
                this.user.hoTen = entryHoTen.Text.ToString();
                this.user.soDienThoai = entrySoDienThoai.Text.ToString();
                this.user.email = entryEmail.Text.ToString();
                this.user.matKhau = entryMatKhau.Text.ToString();
                this.user.ngaySinh = entryNgaySinh.Text.ToString();
                db.insertUser(this.user);

                Navigation.PushAsync(new SignUpSuccessfulPage());
            }
            catch
            {
                DisplayAlert("Thông Báo", "Đăng ký thất bại !", "OK");
            }

        }

        private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            this.user.gioiTinh = radioButton.Content.ToString();
        }
    }
}