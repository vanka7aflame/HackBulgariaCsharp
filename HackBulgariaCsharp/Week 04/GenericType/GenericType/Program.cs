using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { 1, 2, 3, 4, 5 };
            LinkedList<int> list = new LinkedList<int>(integers);
            Stack<int> obj = new Stack<int>(list);
            Console.WriteLine(obj.Contains(4));
            Dequeue<int> newObj = new Dequeue<int>(list);
            Console.WriteLine(obj.Contains(7));
        }
    }
}
