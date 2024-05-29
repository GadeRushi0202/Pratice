using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    public class ArrayListExample
    {
        static void Main(string[] args)
        {
            /* ArrayList list = new ArrayList() { 10,20,30,40,50};
             foreach(int i in list)
             {
                 Console.WriteLine(i);
             }*/
            int[] arr = new int[] {60,70,80,90,100,58,63,78,12,236,475};
            ArrayList list = new ArrayList ();

            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.AddRange(arr);
           // list.Insert(4, 52.25);
            //list.Clear();
            list.Sort();
            list.Reverse();
            list.RemoveRange(2, 5);
            Console.WriteLine("Counrt of List = " + list.Count);
            Console.WriteLine("Capacity of list = "+list.Capacity);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
