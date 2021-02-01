using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 10000;
            string[] guids = Infra.BuildArrayGuids(arraySize);

            Console.WriteLine("====================================");
            Console.WriteLine("Execução sem I/O");
            Console.WriteLine("====================================");

            SequentialSearch.Execute(guids);
            ParallelFor.Execute(guids);

            Console.WriteLine("====================================");
            Console.WriteLine($"Execução com I/O ");
            Console.WriteLine("====================================");

            SequentialSearch.Execute(guids, writeFiles: true);
            ParallelFor.Execute(guids, writeFiles: true);

            Console.ReadKey();
        }

    }
}
