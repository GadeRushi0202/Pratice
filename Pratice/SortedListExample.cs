using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public class SortedListExample
    {
        static void Main(string[] args)
        {
            SortedList st = new SortedList();
            st.Add(".py", "Python");
            st.Add(".cs", "C Sharp");
            st.Add(".doc", "Document");
            st.Remove(".doc");
            foreach(DictionaryEntry item in st)
            {
                Console.WriteLine($"{item.Key}  {item.Value}");
            }

        }
    }
}
