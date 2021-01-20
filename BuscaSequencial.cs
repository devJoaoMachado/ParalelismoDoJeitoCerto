using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BuscaSequencial
    {
        public static void Executar(Func<string[]> arrayBuilder, int sleep = 0)
        {
            Console.WriteLine("- BuscaSequencial");

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            string[] guids = arrayBuilder();
            var ocorrencias = 0;
            for (int i = 0; i < guids.Length; i++)
            {
                if (guids[i].Contains("c-"))
                    Console.Write($"\r Ocorrência: {1 + ocorrencias++}");

                if (sleep > 0)
                    Thread.Sleep(sleep);
            }

            stopWatch.Stop();
            Console.WriteLine("");
            Console.WriteLine("Tempo total em segundos: " + Math.Round((decimal)stopWatch.ElapsedMilliseconds / 1000, 2));
        }

    }
        
}
