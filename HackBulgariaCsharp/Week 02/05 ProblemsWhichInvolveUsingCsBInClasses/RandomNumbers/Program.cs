using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RandomNumbers
{
    class Program
    {
        public static void GenerateRandomMatrix(int rows, int columns, string fileName)
        {
            double[,] matrix = new double[rows, columns];
            Random rnd = new Random();
            using (StreamWriter streamWriter = new StreamWriter(fileName))
            {
                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < columns; col++)
                    {
                        matrix[row, col] = rnd.NextDouble() * 1000;
                        Console.Write("{0,8:0.00} ", matrix[row, col]);
                        streamWriter.Write("{0,8:0.00} ", matrix[row, col]);
                    }
                    Console.WriteLine();
                    streamWriter.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            int rows = 3, columns = 3;
            string fileName = @"C:\vanka7a\VS Projects\HackBulgariaCsharp\Week 02\05 ProblemsWhichInvolveUsingCsBInClasses\RandomNumbers\RndNum.txt";
            GenerateRandomMatrix(rows, columns, fileName);
        }
    }
}
