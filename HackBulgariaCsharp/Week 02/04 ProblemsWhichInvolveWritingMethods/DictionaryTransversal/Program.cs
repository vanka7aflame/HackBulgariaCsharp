using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DictionaryTransversal
{
    class Program
    {
        public static void IterateDirectory(DirectoryInfo dir)
        {
            foreach (var f in dir.GetFileSystemInfos())
            {
                Console.WriteLine(f.Name);
            }
            foreach (var n in dir.GetDirectories())
            {
                Console.WriteLine(n.FullName);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("C:\\Users\\vanka_000\\Desktop\\Ivan");
            IterateDirectory(dir);
        }
    }
}
