using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public interface ICustomer
    {
        string Display();
    }
    public interface IOders
    {
        string Display();
    }

    public class Transaction:ICustomer,IOders
    {
        string ICustomer.Display()
        {
            return "This is Customer";
        }
        string IOders.Display()
        {
            return "This is order";
        }
        static void Main(string[] args)
        {
            ICustomer tc = new Transaction();
            Console.WriteLine(tc.Display());

            IOders ot = new Transaction();
            Console.WriteLine(ot.Display());
        }
    }
}
