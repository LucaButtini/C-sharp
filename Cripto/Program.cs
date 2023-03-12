using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cripto
{
    class Program
    {
        static void Main(string[] args)
        {
            string parola;
            int numeroRandom;
            Random generatore = new Random();
            Console.WriteLine("Inserisci una parola");
            parola = Console.ReadLine();
            char[] buffer = new char[parola.Length];

            for (int i=0; i<parola.Length; i++)
            {
                numeroRandom= generatore.Next(33, 126);
                buffer[i] = Convert.ToChar(numeroRandom);
            }
            for (int i=0; i< buffer.Length; i++)
            {
                Console.Write(buffer[i]);   
            }
            Console.ReadLine();
        }
    }
}
