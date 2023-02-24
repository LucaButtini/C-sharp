using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random1_10Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //generare un valore random da 0 a 9 con il vettore. Dobbiamo fare 10 estrazioni. Dobbiamo stampare quelli che non sono usciti.

            Random generatore = new Random();
            int numero;
            const int GIRI = 10;
            int[] arrayNum = new int[10];

            for (int i = 0; i < GIRI; i++)
            {
                numero = generatore.Next(0, 9);
                arrayNum[numero] = i;

                Console.WriteLine($"Numero estratto: {numero}");
            }
            Console.WriteLine("I numeri non estratti sono");
            for (int i = 0; i < GIRI; i++)
            {
                if (arrayNum[i] == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();

        }
    }
}
