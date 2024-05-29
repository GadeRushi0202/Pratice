using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public class HashSetExample
    {
        static void Main(string[] args)
        {
            HashSet<string> hs = new HashSet<string>();
            hs.Add("Pune");
            hs.Add("Mumbai");
            hs.Add("Beed");
            hs.Add("Nashik");
            hs.Add("Nagpur");
            hs.Remove("Nashik");
            foreach (string s in hs)
            {
                Console.WriteLine(s);
            }
        }
    }
}
