namespace PizzaBlazor8.Models
{
    public class ShoppingBasket
    {
        public Customer Customer { get; set; } = new Customer();
        public List<int> Order { get; set; } = new List<int>();
        public bool HasPaid { get; set; }
        public void AddPizza(int id) => Order.Add(id);

        public void RemoveAt(int pos) => Order.RemoveAt(pos);
    }
}
