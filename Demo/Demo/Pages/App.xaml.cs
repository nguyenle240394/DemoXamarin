using Demo.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage()) { BackgroundColor = Color.FromRgb(192, 192, 192) };
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
