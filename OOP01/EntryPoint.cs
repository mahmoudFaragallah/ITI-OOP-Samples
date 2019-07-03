using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    class EntryPoint
    {
        public static void Main()
        {
            // object from Point class
            Point p = new Point(5, 0);
            p.SetX(0);
            Console.WriteLine(p.GetX());
            Console.ReadLine();
        }
    }
}
