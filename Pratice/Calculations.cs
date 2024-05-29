using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public delegate int MyDelegate (int x,int y);
    public delegate double MyDelegate1 (double x, double y);   
    public class Calculations
    {
        public int Addtion(int a,int b)
        {
            return a + b;
        }
        public double Addtion(double a,double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Calculations c = new Calculations();
            MyDelegate m = new MyDelegate(c.Addtion);

            int result = m.Invoke(25, 63);
            Console.WriteLine("Addition = "+result);

            MyDelegate1 m1 = new MyDelegate1(c.Addtion);
            double result1 = m1.Invoke(25.25, 58.25);
            Console.WriteLine("Division = "+result1);
        }
    }
}
