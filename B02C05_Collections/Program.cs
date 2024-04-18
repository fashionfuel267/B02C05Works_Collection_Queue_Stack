using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02C05_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push("ABC");
        stack.Push(DateTime.Now);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
