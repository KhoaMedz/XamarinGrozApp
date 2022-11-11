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
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            InitializeComponent();
            showData();
        }

        public void showData()
        {
            Database db = new Database();
            lvCartItem.ItemsSource = db.selectAllCartItem();
        }

        private void cmdThanhToan(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OrderSuccessfulPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Database db = new Database();
            lvCartItem.ItemsSource = db.selectAllCartItem();
            tinhTongTien();
        }

        
        private void imageButtonDeleteCartItem(object sender, EventArgs e)
        {
            Database db = new Database();
            CartItem cartItem = (CartItem)((ImageButton)sender).BindingContext;
            db.deleteCartItem(cartItem);
            lvCartItem.ItemsSource = db.selectAllCartItem();
            tinhTongTien();
        }

        private void tinhTongTien()
        {
            long tongTien = 0;
            List<CartItem> cartItemList = new List<CartItem>();
            Database db = new Database();
            cartItemList = db.selectAllCartItem();

            foreach(CartItem cartItem in cartItemList)
            {
                tongTien += cartItem.tongGiaSanPham;
            }

            lblTongTien.Text = tongTien.ToString() + " $";
        }
    }
}