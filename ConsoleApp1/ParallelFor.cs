using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ParallelFor
    {
        public static void Execute(
            string[] guids,
            bool writeFiles = false)
        {
            Console.WriteLine("- ParallelFor");

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            var occurrencies = 0;
            Action<int> action = (param) =>
            {
                if (guids[param].Contains("c-"))
                {
                    Console.Write($"\r Ocorrências 'c-': {1 + occurrencies++}");

                    if (writeFiles)
                        Infra.WriteTxtFile(guids[param]);
                }
            };

            Parallel.For(0, guids.Length, action);

            stopWatch.Stop();
            Console.WriteLine("");
            Console.WriteLine("Tempo total em segundos: " + Math.Round((decimal)stopWatch.ElapsedMilliseconds / 1000, 2));

        }
    }
}
