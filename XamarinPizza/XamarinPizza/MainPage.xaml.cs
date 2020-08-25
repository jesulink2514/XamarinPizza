using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinPizza.Model;

namespace XamarinPizza
{
    public partial class MainPage : INotifyPropertyChanged
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override async void OnAppearing()
        {
            IsLoading = true;
            Pizzas = await App.PizzaService.GetPizzas();
            IsLoading = false;
        }

        public bool IsLoading { get; set; }
        public Pizza[] Pizzas { get; set; }
    }
}
