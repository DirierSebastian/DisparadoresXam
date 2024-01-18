using DisparadoresXam.Vista;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DisparadoresXam
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Categoria();
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
