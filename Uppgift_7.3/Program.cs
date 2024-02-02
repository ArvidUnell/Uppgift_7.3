using System;
using System.Collections.Generic;
namespace Uppgift_7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ländersYtor = new Dictionary<string, int>();
            ländersYtor["sverige"] = 450;
            ländersYtor["norge"] = 385;
            ländersYtor["danmark"] = 43;
            ländersYtor["finland"] = 338;

            Console.WriteLine("Skriv ett land för att få storleken av det");
            string inputLand = Console.ReadLine().ToLower();

            if (ländersYtor.ContainsKey(inputLand))
            {
                Console.WriteLine($"{inputLand}s yta är {ländersYtor[inputLand]*100000} km^2");
            }
            else
            {
                Console.WriteLine("Tyvärr, det landet finns inte i listan.");
            }


            Console.WriteLine("\nTryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}