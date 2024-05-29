using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public enum Categories { Furniture = 1, Homeneeds, Electronics };
    public class EnumExample
    {
        public int Id,Price;
        public string Name;
        public Categories Category;

        public EnumExample(int Id,int Price,string Name,Categories Category)
        {
            this.Id = Id;
            this.Price = Price;
            this.Name = Name;
            this.Category = Category;
        }
        public string Display()
        {
            return $"Id = {Id} Price ={Price} Name ={Name} Category = {Category}";
        }
        static void Main(string[] args)
        {
            EnumExample ee = new EnumExample(1, 500, "Mouse", Categories.Electronics);
            Console.WriteLine(ee.Display());
        }
    }
}
