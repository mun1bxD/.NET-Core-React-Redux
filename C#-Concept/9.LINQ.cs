using System.Linq;

namespace LINQ
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

        class Program
        {
            static void Main(String[] args)
            {
            List<Product> products = new List<Product>
                {
                    new Product{Id=1,Name="lux", Category="soap",Price=10},
                    new Product{Id=2, Name="Bonus",Category="surf",Price=5},
                    new Product{Id=3, Name="Tiger",Category="Biscuit",Price=1},
                    new Product{Id=4, Name="tooti fruiti",Category="candy",Price=2},
                    new Product{Id=4, Name="fanta",Category="candy",Price=2}
                };

            var result = products.Where(p => p.Name == "Tiger");

            products.ForEach(product => Console.WriteLine("ID: {0}",product.Id));

            var OrderedProduct = products.OrderBy(p => p.Name);

            var MultipleOrder=products.OrderBy(p => p.Name).ThenBy(p=>p.Price);

            var MaxProduct=products.Max(p => p.Price);

            var MaxPriceProduct = products.Where(p => p.Price == MaxProduct);
            
            var GroupProduct=products.GroupBy(p=> p.Category);

            foreach (var group in GroupProduct)
            {
                Console.WriteLine("Producr in :"+group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine(item.Id + " " + item.Name + " " + item.Category + " " + item.Price);
                }
            }
            }
        }
    }
