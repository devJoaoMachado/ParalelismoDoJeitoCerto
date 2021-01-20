﻿using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ParallelFor
    {
        public static void Executar(Func<string[]> arrayBuilder, int sleep = 0)
        {
            Console.WriteLine("- ParallelFor");

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            string[] guids = arrayBuilder();

            var ocorrencias = 0;
            Action<int> action = (param) =>
            {
                if (guids[param].Contains("c-"))
                    Console.Write($"\r Ocorrência: {1 + ocorrencias++}");

                if (sleep > 0)
                    Thread.Sleep(sleep);
            };

            Parallel.For(0, guids.Length, action);
            
            stopWatch.Stop();
            Console.WriteLine("");
            Console.WriteLine("Tempo total em segundos: " + Math.Round((decimal)stopWatch.ElapsedMilliseconds / 1000, 2));

        }
    }
}