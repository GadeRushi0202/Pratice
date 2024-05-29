using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public interface IPrinttable
    {
        string Print();
    }
    public interface ITaxable
    {
        void Tax();
    }

    public class User:IPrinttable, ITaxable
    {
        public string Print()
        {
            return "Print Table";
        }
        public void Tax()
        {
            Console.WriteLine("Pay Tax");
        }
       
        static void Main(string[] args)
        {
            User user = new User();
            user.Tax();
            /*Console.WriteLine(user.Print()); */
            Console.WriteLine(user.Print());
        }
    }
    
}
