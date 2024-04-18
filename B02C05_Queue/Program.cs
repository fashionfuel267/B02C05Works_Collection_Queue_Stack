using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02C05_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(9);
            string data = "";
            foreach (var item in queue)
            {
                //Console.Write(item+"\t");
                data += item + ",";
            }
            data=data.Substring(0, data.Length - 1);
            Console.Write(data);
            Console.ReadKey();

        }
    }
}
