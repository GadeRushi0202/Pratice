using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
     public class StaticConstructor
    {
        protected int Id;
        protected string Name;
        public static int count;

        public StaticConstructor(int Id,string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }

        static StaticConstructor()
        {
            
            //count =10;
            count++;
        }
        public string Display()
        {
            return $"Id ={Id} Name ={Name} Count ={count}";
        }
        static void Main(string[] args)
        {
            StaticConstructor sc = new StaticConstructor(1,"Rushi");
            Console.WriteLine(sc.Display());

            StaticConstructor sc1 = new StaticConstructor(1, "Rushi");
            Console.WriteLine(sc1.Display());
        }
    }
}
