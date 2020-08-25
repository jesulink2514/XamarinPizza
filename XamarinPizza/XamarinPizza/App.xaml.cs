using System;
using Refit;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinPizza.Services;

namespace XamarinPizza
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            PizzaService = RestService.For<IPizzaService>("https://blazingpizzaserver20200824202419.azurewebsites.net");
        }

        public static IPizzaService PizzaService { get; private set; }

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
