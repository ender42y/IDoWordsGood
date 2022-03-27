using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using I_Do_Words_Good.Views;

namespace I_Do_Words_Good
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new MainMenu();
            MainPage = new NavigationPage(new MainMenu());
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
