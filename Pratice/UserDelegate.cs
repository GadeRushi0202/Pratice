using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public delegate string MyDelegateName(string Name);
    public class UserDelegate
    {
        public string ConverToUpper(string Name)
        {
            return Name.ToUpper();
        }
        static void Main(string[] args)
        {
            UserDelegate ud = new UserDelegate();
            Console.WriteLine("Enter a Name");
            string Name = Console.ReadLine();

            MyDelegateName mdn = new MyDelegateName(ud.ConverToUpper);
            string result = ud.ConverToUpper(Name);
            Console.WriteLine(result);
        }
    }
}
