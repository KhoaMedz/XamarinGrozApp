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
    public partial class productDetailsPage : ContentPage
    {
        List<Product> listProduct = new List<Product>();
        Product product;
        public productDetailsPage()
        {
            InitializeComponent();
        }

        public productDetailsPage(Product product)
        {
            InitializeComponent();
            this.product = product;
            listProduct.Add(this.product);
            lvProductDetails.ItemsSource = listProduct;
        }

        private void btnThemVaoGioHang_Clicked(object sender, EventArgs e)
        {
            CartItem cartItem = new CartItem();
            cartItem.tenSanPham = this.product.tenSanPham;
            cartItem.hinhSanPham = this.product.hinhSanPham;
            cartItem.giaSanPham = this.product.giaSanPham;
            cartItem.soLuong = int.Parse(entrySoLuong.Text);
            cartItem.tongGiaSanPham = cartItem.giaSanPham * cartItem.soLuong;

            try
            {
                Database db = new Database();
                db.insertCartItem(cartItem);
                DisplayAlert("Thông báo", "Thêm vào giỏ thành công !", "OK");
            }
            catch
            {
                DisplayAlert("Thông báo", "Thêm vào giỏ thất bại", "OK");

            }
        }
    }
}