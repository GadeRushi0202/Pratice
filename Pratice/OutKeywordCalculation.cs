using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public class OutKeywordCalculation
    {
        static void Calculation(int a,int b,out int sum,out int mul,out int sub)
        {
            sum = a + b;
            mul = a*b;
            sub = a - b;
        }
        static void Main(string[] args)
        {
            int a = 25, b = 5 ,sum,mul,sub;
            Calculation( a, b,out sum,out mul,out sub);
            Console.WriteLine("Addition = "+sum);
            Console.WriteLine("Substraction = "+sub);
            Console.WriteLine("Multiplication = "+mul);
        }
    }
}
