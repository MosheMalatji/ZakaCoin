using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZakaCoin.Services;
using ZakaCoin.Views;
using ZakaCoin.Views.Login;
namespace ZakaCoin
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TabbedForm());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
