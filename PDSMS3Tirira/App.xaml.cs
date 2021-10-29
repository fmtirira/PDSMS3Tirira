using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDSMS3Tirira
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Habilitar navegacion grafica de las ventanas
            MainPage = new NavigationPage( new MainPage());
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
