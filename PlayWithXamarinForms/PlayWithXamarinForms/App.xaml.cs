using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PlayWithXamarinForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new GreetPage();
            //MainPage = new StackPage();
            //MainPage = new GridView();
            //MainPage = new AbsolutePage();
            //MainPage = new RelativePage();
            //MainPage = new ImagePage();
            MainPage = new Lists();
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
