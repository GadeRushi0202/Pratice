using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Pratice
{
    abstract public class Shape
    {
        public abstract void Area();
        public abstract string Display(string Name);
    }
        public class Circle : Shape
        {
            private const double pi = 3.14;
            private int r;
            private double area;

            public Circle(int r)
            {
                this.r = r;
            }
            public override void Area()
            {
                area = pi * r * r;
            }
            public string Print()
            {
                return $"area of Circle = {area}";
            }
            public override string Display(string Name)
            {
                return $"Name ={Name}";
            }
        static void Main(string[] args)
        {
            Circle c = new Circle(10);  
            c.Area();
            Console.WriteLine(c.Print());
        }
        
         }
}

