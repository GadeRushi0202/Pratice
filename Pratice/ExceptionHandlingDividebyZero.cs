using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public class ExceptionHandlingDividebyZero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a First Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            
            try
            {
                int c = a / b;
                Console.WriteLine("Division = "+c);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
