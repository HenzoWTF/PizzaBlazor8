﻿
namespace PizzaBlazor8.Models
{
    public class Pizza
    {
        public Pizza(int id, string name, decimal price, Spiciness spiciness)
        {
            Id = id;
            Name = name;
            Price = price;
            Spiciness = spiciness;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Spiciness Spiciness { get; set; }

    }
}
