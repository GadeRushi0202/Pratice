using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public  class Employee
    {
        public int Id;
        public string Name;
        public double Salary;
        public Employee(int Id,string Name , double Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
        }
        public string Display()
        {
            return $"Id = {Id} Name = {Name} Salary = {Salary}";
        }

        static void Main(string[] args)
        {
            Employee Emp = new Employee(1, "Rushi", 350000);
            Console.WriteLine(Emp.Display());
        }
    }
}
