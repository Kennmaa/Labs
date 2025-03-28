using System;
using System.Collections.Generic;

class Program
{
    struct Product
    {
        public string Name;
        public int Amount;
        public decimal Price;
        public string Maker;
        public DateTime Date;
    }

    static void Main()
    {

        List<Product> products = new List<Product>();


        products.Add(new Product()
        {
            Name = "Телефон",
            Amount = 10,
            Price = 500m,
            Maker = "Samsung",
            Date = new DateTime(2023, 5, 10)
        });

        products.Add(new Product()
        {
            Name = "Ноутбук",
            Amount = 5,
            Price = 1200m,
            Maker = "Lenovo",
            Date = new DateTime(2023, 6, 15)
        });

        products.Add(new Product()
        {
            Name = "Наушники",
            Amount = 20,
            Price = 100m,
            Maker = "Xiaomi",
            Date = new DateTime(2023, 7, 1)
        });

        decimal averagePrice = 0;
        foreach (var p in products)
        {
            averagePrice += p.Price;
        }
        averagePrice /= products.Count;

        Console.WriteLine($"Средняя цена: {averagePrice} руб.");
        Console.WriteLine("\nТовары дороже средней цены:");


        foreach (var p in products)
        {
            if (p.Price > averagePrice)
            {
                Console.WriteLine($"{p.Name} - {p.Price} руб. ({p.Maker})");
            }
        }
    }
}