using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public class List_Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        static void Main(string[] args)
        {
            List<List_Product> Product = new List<List_Product>()
            {
                new List_Product{Id=1, Name="IPhone",Price=75000},
                new List_Product{Id=2, Name="Redmi",Price=7500},
                new List_Product{Id=3, Name="OnePluse",Price=21500},
                new List_Product{Id=4, Name="Samsang",Price=19500},
                new List_Product{Id=5, Name="Redmi",Price=7000},

            };
            foreach(var item in Product)
            {
                if(item.Price > 20000)
                {
                    Console.WriteLine($"Id = {item.Id}  Name = {item.Name} Price = {item.Price} " );
                }
            }

        }
    }
}
