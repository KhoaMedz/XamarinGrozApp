using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GrozApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Database db = new Database();
            db.createDatabase();
            db.createProductTypeData();
            db.createProductData();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
