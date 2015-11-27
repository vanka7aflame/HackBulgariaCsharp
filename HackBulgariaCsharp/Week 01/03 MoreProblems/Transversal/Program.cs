using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transversal
{
    class Program
    {{
        public static bool NumberContains(List<int> transversal, List<int> family)
        {
            bool check = false;
            foreach (var number in transversal)
            {
                for (int i = 0; i < family.Count; i++)
                {
                    if (family.Contains(number))
                    {
                        check = true;
                        break;
                    }
                }
            }
            return check;
        }
        public static bool IsTransversal(List<int> transversal, List<List<int>> family)
        {
            List<int> newFamily = new List<int>();
            bool check = false;
            foreach (var list in family)
            {
                if (NumberContains(transversal, list))
                {
                    check = true;
                }
                else
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
        static void Main(string[] args)
        {
            List<int> transversal = new List<int> { 7, 5, 8 };
            List<List<int>> family = new List<List<int>>();
            family.Add(new List<int> { 1, 7 });
            family.Add(new List<int> { 2, 3, 5 });
            family.Add(new List<int> { 4, 8 });
            Console.WriteLine(IsTransversal(transversal, family));
        }
    }
}
