using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public struct StructExample
    {
        public int Id;
        public string Name;
        public int Price;

        public StructExample(int Id, string Name , int Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }
        public string Print()
        {
            return $"Id = {Id} Name = {Name} Price = {Price}";
        }
        static void Main(string[] args)
        {
            StructExample se = new StructExample(1,"Pen",15);
            Console.WriteLine(se.Print());
        }
    }
}
