using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public class Person
    {
        protected string Name;
        protected int Age;
        public Person(string Name , int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public virtual string Display()
        {
            return $" Name = {Name} Age = {Age}";
        }

        public class Patient:Person
        {
            private string BloodGroup;
            private string Gender;
            private int fee;
            public Patient(string BloodGroup,string Gender,int fee,string Name ,int Age):base(Name ,  Age)
            {
                this.BloodGroup = BloodGroup;
                this.Gender = Gender;
                this.fee= fee;  
            }
            public override string Display()
            {
                return $"Name = {Name} Age = {Age}  BloodGroup = {BloodGroup}  Gender = {Gender} Fee = {fee}";
            }
        }

        static void Main(string[] args)
        {
            Patient p = new Patient("A+", "Male", 500, "Rushi", 23);
            Console.WriteLine(p.Display()); 
        }
    }
}
