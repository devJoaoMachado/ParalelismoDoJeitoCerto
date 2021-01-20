using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanhoArrayTeste = 1000;
            Console.WriteLine("==========================================================");
            Console.WriteLine("Execução sem I/O");
            Console.WriteLine("==========================================================");
            BuscaSequencial.Executar(()=> CriarArrayGuids(tamanhoArrayTeste));
            ParallelFor.Executar(() => CriarArrayGuids(tamanhoArrayTeste));

            int milisegundosIO = 10;
            Console.WriteLine("==========================================================");
            Console.WriteLine($"Execução simulando I/O {milisegundosIO}(ms) para cada iteração do loop");
            Console.WriteLine("==========================================================");
            BuscaSequencial.Executar(() => CriarArrayGuids(tamanhoArrayTeste), milisegundosIO);
            ParallelFor.Executar(() => CriarArrayGuids(tamanhoArrayTeste), milisegundosIO);

            Console.ReadKey();
        }

        private static string[] CriarArrayGuids(int tamanhoArray)
        {
            var guids = new string[tamanhoArray];

            for (int i = 0; i < guids.Length; i++)
            {
                guids[i] = Guid.NewGuid().ToString();
            }

            return guids;
        }

    }
}
