using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    internal class Continue_Example
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                if(i == 8)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            
        }
    }
}
