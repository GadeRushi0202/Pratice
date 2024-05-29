using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public class RefKeywordUsingSwap
    {
        static void Sawp(ref int a, ref int b)
        {
            int temp = a;
            a =b;
            b=temp;
        }

        static void Main(string[] args)
        {
            int a = 100, b = 200;
            Sawp(ref a, ref b);
            Console.WriteLine("a = "+a +" " + "b = " +b);
        }
    }
}
