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
            Queue q1 = new Queue();
            Queue q2 = new Queue(3);

            int i = 1;
            while (q2.Push(i))
            {
                i++;
            }
            q2.SetSize(7);
            q2.Push(17);
            q2.Push(20);
            q2.Push(24);
            q2.Push(222);

            int no;
            while (q2.Pop(out no))
            {
                Console.WriteLine(no);
            }
            Console.ReadLine();
        }
    }
}
