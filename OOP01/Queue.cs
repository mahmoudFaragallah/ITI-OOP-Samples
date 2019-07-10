using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    class Queue
    {
        int[] data;
        int size;  //Size of Queue
        int count; // Count elements num of Queue
        int toq;  // Top of Queue
        int eoq;  // End of Queue

        public int GetSize()
        {
            return size;
        }
        public bool SetSize(int _size)
        {
            bool result;
            if (_size >= count)
            {
                Queue temp = new Queue(_size);
                int no;
                while (Pop(out no))
                {
                    temp.Push(no);
                }
                size = temp.size;
                toq = temp.toq;
                eoq = temp.eoq;
                data = temp.data;
                count = temp.count;
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public int GetCount()
        {
            return count;
        }
        public Queue(int _size)
        {
            data = new int[_size];
            size = _size;
            toq = 0;
            eoq = 0;
            count = 0;
        }
        public Queue()
        {
            data = new int[10];
            size = 10;
            toq = 0;
            eoq = 0;
            count = 0;
        }
        public bool Push(int no)
        {
            bool result;
            if (count < size)
            {
                data[eoq] = no;
                eoq++;
                if (eoq == size)
                {
                    eoq = 0;
                }
                count++;

                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        //alternative Pop() function
        //public int? Pop()
        //{
        //    int? result = null;
        //    if (count > 0)
        //    {
        //        result = data[toq];
        //        toq++;
        //        if (toq == size)
        //        {
        //            toq = 0;
        //        }
        //        count--;
        //    }
        //    return result;
        //}

        public bool Pop(out int no)
        {
            no = 0;
            bool result;
            if (count > 0)
            {
                no = data[toq];
                toq++;
                if (toq == size)
                {
                    toq = 0;
                }
                count--;
                result = true;

            }
            else
            {
                result = false;
            }
            return result;
        }
    }
}
