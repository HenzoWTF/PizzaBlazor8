namespace PizzaBlazor8.Models
{
    public class Menu
    {
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

        public void AddPizza(Pizza pizza) => Pizzas.Add(pizza);

        public void RemovePizza(int id) => Pizzas.RemoveAll(p => p.Id == id);

        public Pizza? GetPizza(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

    }
}
