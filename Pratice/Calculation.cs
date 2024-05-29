using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public class Calculation
    {
        public int Addition(int x,int y)
        {
            return x + y;
        }
        public int Addition(int x , int y, int z)
        {
            return x + y + z;
        }
        public double Addition(int x,double y)
        {
            return x + y;
        }
        public double Addition (double x,double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            Console.WriteLine(c.Addition(56.2, 45.9));
            Console.WriteLine(c.Addition(56.2, 45.9));
            
            Console.WriteLine(c.Addition(82, 36));
        }
    }
}
