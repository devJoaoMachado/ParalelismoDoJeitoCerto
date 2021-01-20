using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    public class Infra
    {
        public static string[] BuildArrayGuids(int tamanhoArray)
        {
            var guids = new string[tamanhoArray];

            for (int i = 0; i < guids.Length; i++)
            {
                guids[i] = Guid.NewGuid().ToString();
            }

            return guids;
        }

        public static void WriteTxtFile(string guid)
        {
            string docPath = Path.Combine(Environment.CurrentDirectory, $"{guid}.txt");
            using (StreamWriter outputFile = new StreamWriter(docPath))
            {
                outputFile.WriteLine(guid);
            }
        }
    }
}
