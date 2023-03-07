using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversione_B2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dato un numero nel range 0-->255 convertirlo in base 2
            int x, y, num;//variabili
            x = Console.WindowWidth / 2;
            y = Console.WindowHeight / 2;

            do
            {
                Console.WriteLine("Inserire un numero nel range 0-->255"); //inserimento dati input
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0 || num > 255)
                {
                    Console.WriteLine("OUT OF RANGE (PREMI INVIO PER CONTINUARE)");//errore di inserimento numero
                    Console.ReadLine();
                }
            } while (num < 0 || num > 255);
            while (num >= 1) //conversione
            {
                if (num % 2 == 0)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("0");
                    num = num / 2;
                }
                else
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write("1");
                    num = num / 2;
                }
                x = x - 1;
            }
            Console.ReadLine() ;
        }
    }
}
