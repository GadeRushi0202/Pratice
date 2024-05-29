using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public class Method_Date
    {
        public int Day;
        public string Month;
        public int Year;

        public Method_Date(int Day,  string Month, int Year)
        {
            this.Day = Day;
            this.Month = Month;
            this.Year = Year;
        }
        public string Display_Date()
        {
            return $"{Day}  /  {Month} / {Year} ";
        }
        static void Main(string[] args)
        {
            Method_Date md = new Method_Date(02,"Feb",2001);
            Console.WriteLine(md.Display_Date());
            //or
            Method_Date md1 = new Method_Date(01, "Aug", 2001);
            string res = md1.Display_Date();
            Console.WriteLine(res);
        }
    }
}
