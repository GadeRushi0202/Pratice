using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public class BoxingUnBoxingExample
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(24);
            list.Add(84.40);//Boxing Implicit
            list.Add("Pune");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }

            //Unboxing Explicit
            double d = Convert.ToDouble(list[1]);
            Console.WriteLine(d);
            string str = list[2].ToString();
            Console.WriteLine(str);
        }
    }
}
