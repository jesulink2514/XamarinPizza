using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;
using XamarinPizza.Model;

namespace XamarinPizza.Services
{
    public interface IPizzaService
    {
        [Get("/specials")]
        Task<Pizza[]> GetPizzas();
    }
}
