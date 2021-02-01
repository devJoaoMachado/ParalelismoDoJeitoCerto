using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 10000;
            
            Console.WriteLine("====================================");
            Console.WriteLine("Execução sem I/O");
            Console.WriteLine("====================================");

            SequentialSearch.Execute(arraySize);
            ParallelFor.Execute(arraySize);

            Console.WriteLine("====================================");
            Console.WriteLine($"Execução com I/O ");
            Console.WriteLine("====================================");

            SequentialSearch.Execute(arraySize, writeFiles: true);
            ParallelFor.Execute(arraySize, writeFiles: true);

            Console.ReadKey();
        }

    }
}
