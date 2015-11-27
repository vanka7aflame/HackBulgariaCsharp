using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInAList
{
    class Program
    {
        public static bool TryFindSubstring(List<string> list, string searched, out int foundIndex)
        {
            foundIndex = 0;
            for (int c = 0; c < list.Count; c++)
            {
                if (list[c].Contains(searched))
                {
                    foundIndex = c;
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "ivan", "vankata", "petrov" };
            string searched = "vankata";
            int foundIndex;
            Console.WriteLine(TryFindSubstring(list, searched, out foundIndex));
            Console.WriteLine(foundIndex);
        }
    }
}
