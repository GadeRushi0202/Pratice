using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public class AutoImplementProperty
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public double Salary { get; set; }

        public string Display()
        {
            return $"Id = {Id} Name =  {Name} Salary = {Salary}";
        }
        static void Main(string[] args)
        {
            AutoImplementProperty ap = new AutoImplementProperty()
            {
                Id = 1,
                Name = "Rushi",
                Salary = 24500.25
            };
            Console.WriteLine(ap.Display());


        }
    }
}
