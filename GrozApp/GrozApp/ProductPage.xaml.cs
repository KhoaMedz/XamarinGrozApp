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
    public partial class ProductPage : ContentPage
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        public ProductPage(ProductType productType)
        {
            InitializeComponent();
            lblTittle.Text = productType.tenLoai;
            Database db = new Database();
            cvProduct.ItemsSource = db.selectProductByType(productType.maLoai);
        }

        private void cvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Product selectedItem = e.CurrentSelection[0] as Product;
            Navigation.PushAsync(new productDetailsPage(selectedItem));
        }
    }
}