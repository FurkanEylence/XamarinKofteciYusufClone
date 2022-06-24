using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinKofteciYusufClone.Views;

namespace XamarinKofteciYusufClone
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new LoginView());
            //MainPage = new NavigationPage(new SettingPage());
            string uname = Preferences.Get("Username", String.Empty);
            if (string.IsNullOrEmpty(uname))
            {
                MainPage = new LoginView();
            }
            else
            {
                MainPage = new ProductsView();
            }
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
