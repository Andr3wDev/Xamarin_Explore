using System;
using Travel.Autofac;
using Travel.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Travel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DIContainer.Initialize();
            MainPage = new NavigationPage(new HomeView());
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
