using Microsoft.Extensions.Options;
using System.Text.Json;

namespace PizzaBlazor8.Models
{
    public class State
    {
        public Menu Menu { get; set; } = new Menu();
        public ShoppingBasket Basket { get; set; } = new ShoppingBasket();
        public UI UI { get; set; } = new UI();

        public decimal TotalPrice => Basket.Order.Sum(id => Menu.GetPizza(id)!.Price);
    }
}
