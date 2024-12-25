    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Interfaces
    {
       public  interface IInventoryItem
        {
            string Name { get; }
            decimal Price { get; }
            int Quantity { get; }

            decimal getTotalValue();
        }
        public class Electronic : IInventoryItem
        {
            public string Brand { get;}
            public decimal Price { get; }
            public int Quantity { get; }
            public string Name { get;}

            public Electronic (string name, decimal price, int quantity, string brand)     
            {
                Name=name;
                Price=price;
                Quantity=quantity;
                Brand = brand;
            }
            
            public decimal getTotalValue()
            {
                return Price*Quantity;
            }
        }
        public class Clothing : IInventoryItem
        {
            public string Size { get; }
            public decimal Price { get; }
            public int Quantity { get; }
            public string Name { get; }

            public Clothing(string name, decimal price, int quantity, string size)
            {
                Size=size;
                Price=price;
                Quantity=quantity;
                Name = name;
            }

            public decimal getTotalValue()
            {
                 return Quantity*Price;
            }
        }
        public class Food : IInventoryItem
        {
            public DateTime ExpirationDate { get; }
            public string Name { get; }
            public decimal Price { get; }
            public int Quantity { get; }

            public Food(string name, decimal price, int quantity, DateTime expirationDate)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
                ExpirationDate = expirationDate;
            }

            public decimal getTotalValue()
            {
                return Price * Quantity;
            }
    }
    public class Inventory
    {
        protected List<IInventoryItem> items = new List<IInventoryItem>();

        public void AddItem(IInventoryItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(IInventoryItem item)
        {
            items.Remove(item);
        }

        public decimal SumProductValue()
        {
            return items.Sum(x => x.getTotalValue());
        }

        public void Display()
        {
            foreach (IInventoryItem item in items)
            {
                Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Quantity: {item.Quantity}, Total Value: {item.getTotalValue()}");
            }
        }
    }
        internal class Program
        {
            static void Main(string[] args)
            {
                Inventory inventory = new Inventory();

            Food food = new Food("Apple", 0.99m, 100, DateTime.Now.AddDays(7));
            inventory.AddItem(food);
            inventory.Display();
            Console.ReadKey();
            }
        }
    }
