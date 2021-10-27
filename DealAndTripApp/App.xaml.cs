using DealAndTripApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using DealAndTripApp.Models;

namespace DealAndTripApp
{
    public partial class App : Application
    {
        public User currentUser;
        public static bool IsDevEnv
        {
            get
            {
                return true; //change this before release!
            }
        }
        public App()
        {
            InitializeComponent();
            currentUser = null;
            MainPage = new LoginPage();
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
