using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decimaleInBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            //dato numero in base 10 (nel range 0, 255) convertirlo in base 2. Quando il dividendo diventa zero abbiamo raggiunto il nostro scopo.
            int numero, resto, x, contabit = 8;
            double risultato=0, peso=0;

            do
            {
                Console.WriteLine("Inserisci un valore decimale");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero < 0 || numero > 255)
                {
                    Console.WriteLine("Out of range. Premi invio per continuare");
                    Console.ReadLine();
                }
            } while (numero < 0 || numero > 255);

            //primo metodo

            //Console.WriteLine("Valore in base 2:");
            ////Console.Write(Console.CursorLeft);
            //x = Console.CursorLeft += 8;
            ////conversione 
            //do
            //{
            //    resto = numero % 2;
            //    numero = numero / 2;
            //    x = x - 1;
            //    contabit = contabit - 1;

            //    Console.CursorLeft = x;
            //    Console.Write(resto);
            //} while (contabit != 0);
            //Console.CursorLeft = +7;
            //Console.Write(" ");


            //secondo modo

            //do
            //{
            //    resto = numero % 2;
            //    numero = numero / 2;
            //    contabit--;//serve per mettere gli zeri che mancano
            //    risultato = resto + risultato;
            //} while (contabit != 0);
            //Console.WriteLine(risultato);
            //Console.WriteLine(risultato);


            //terzo modo
            //prendere le cifre come se fossero  in base 10, prendo la base 10 e la elevo per il peso, moltiplicandola per la cifra binaria
            do
            {
                resto = numero % 2;
                numero = numero / 2;
                risultato = risultato + resto * Math.Pow(10, peso); //Math.Pow è la potenza
                peso++;
            } while (numero != 0);
            Console.WriteLine("{0:00000000}",risultato); //mi scrive il risultato sopra gli zeri
            Console.ReadLine();

        }
    }
}
