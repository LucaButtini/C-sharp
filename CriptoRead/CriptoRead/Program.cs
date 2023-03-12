using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriptoRead
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numeroRandom;
            Random generatore = new Random();
            string parola = "";
            char carattere;
            Console.WriteLine("Inserisci una parola");
            do
            {

                carattere = Convert.ToChar(Console.Read());
                parola = parola + carattere;
            } while (carattere != '\r');

            char[] car = new char[parola.Length];
            car[0] = carattere;
            char[] buffer = new char[parola.Length];
            for (int i = 0; i < parola.Length; i++)
            {
                numeroRandom = generatore.Next(33, 126);
                buffer[i] = Convert.ToChar(numeroRandom);
            }
            for (int i = 0; i < parola.Length; i++)
            {
                car[i] = buffer[i];
            }
            Console.WriteLine(car);
            Console.ReadLine();
            Console.ReadLine();
            /*string parola;
            int numeroRandom;
            Random generatore = new Random();
            Console.WriteLine("Inserisci una parola");
            parola = Console.ReadLine();
            char[] buffer = new char[parola.Length];

            for (int i = 0; i < parola.Length; i++)
            {
                numeroRandom = generatore.Next(33, 126);
                buffer[i] = Convert.ToChar(numeroRandom);
            }
            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write(buffer[i]);
            }
            Console.ReadLine();*/
        }
    }
}

