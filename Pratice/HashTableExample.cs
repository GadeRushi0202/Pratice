using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public class HashTableExample
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(".docs", "Document");
            ht.Add(".py", "Python");
            ht.Add(".cs", "C Sharp");
            ht.Remove(".py");
            foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }
    }
}
