using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
     public class SetGetExample
    {
        private int Id;
        private string Name;
        private double Salary;

        public int id
        {
            set { Id = value; }
            get { return Id; }
        }
        public string name
        {
            set { Name = value; }
            get { return Name;}
        }
        public double salary
        {
            set { Salary = value; }
            get { return Salary; }
        }
        public string Print()
        {
            return $"Id = {id} Name = {Name}  Salary = {Salary}";
         }
        static void Main(string[] args)
        {
            SetGetExample se = new SetGetExample();
            se.id = 1;
            se.name = "Test";
            se.salary = 25000;
            Console.WriteLine(se.Print());
            //or
            SetGetExample se1 = new SetGetExample()
            {
                Id = 2,
                Name = "Rishi",
                Salary = 450000

            };
            Console.WriteLine(se1.Print());
        }
    }
}
