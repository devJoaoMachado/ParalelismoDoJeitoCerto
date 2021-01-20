using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp1
{
    public class SequentialSearch
    {
        public static void Execute(
            int arraySize, 
            bool writeFiles = false)
        {
            Console.WriteLine("- SequentialSearch");

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            string[] guids = Infra.BuildArrayGuids(arraySize);
            var occurrencies = 0;
            
            for (int i = 0; i < guids.Length; i++)
            {
                if (guids[i].Contains("c-"))
                {
                    Console.Write($"\r Ocorrências 'c-': {1 + occurrencies++}");

                    if (writeFiles)
                        Infra.WriteTxtFile(guids[i]);
                }
            }

            stopWatch.Stop();
            Console.WriteLine("");
            Console.WriteLine("Tempo total em segundos: " + Math.Round((decimal)stopWatch.ElapsedMilliseconds / 1000, 2));
        }

    }
        
}
