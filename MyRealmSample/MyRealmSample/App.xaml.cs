using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyRealmSample
{
    public partial class App : Application
    {
        public App()
        {
            //Commento file app
            //altra modifica master
            //2
            InitializeComponent();

            MainPage = new MainPage();
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
