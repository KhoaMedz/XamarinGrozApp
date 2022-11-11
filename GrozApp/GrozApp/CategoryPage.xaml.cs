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
    public partial class CategoryPage : ContentPage
    {
        public CategoryPage()
        {
            InitializeComponent();
            showData();
        }

        //private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new CartPage());
        //}

        // Gan du lieu loai san pham cho <ListView> và hiển thị lên màn hình
        void showData()
        {
            Database db = new Database();
            lvProductType.ItemsSource = db.selectAllProductType();

        }

        private void cmdChonLoaiSanPham(object sender, SelectedItemChangedEventArgs e)
        {
            ProductType productType;

            if(e.SelectedItemIndex >= 0)
            {
                productType = (ProductType)e.SelectedItem;
                Navigation.PushAsync(new ProductPage(productType));
            }
        }
    }
}