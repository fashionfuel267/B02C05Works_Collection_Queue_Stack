using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02C05_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<CDAlbum> stack = new Stack<CDAlbum>();
            stack.Push(new CDAlbum { Id=1,Name="C sharp"});
            stack.Push(new CDAlbum { Id = 2, Name = "HTML" });
            stack.Push(new CDAlbum { Id = 3, Name = "XML" });
            Console.Write($" Name\t\t Id\n");
            Console.Write("========================\n");
            foreach (CDAlbum album in stack)
            {
                Console.Write($" {album.Name}\t {album.Id}\n");
            }
         var item=   stack.Peek();
            Console.Write($"Peek the last item: {item.Name}\n");
            stack.Pop();
            foreach (CDAlbum album in stack)
            {
                Console.Write($" {album.Name}\t {album.Id}\n");
            }
            Console.ReadKey();
        }
    }
}
