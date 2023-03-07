using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRead
{
    class Program
    {
        static void Main(string[] args)
        {
            //la read mi permette di leggere dal flusso di dati input un carattere alla volta e permette di leggere anche il carriage return e feed.
            int valchar;
            char car;
            string caratteri = "";
            string numeri = "";
            do
            {
                valchar = Console.Read();  //il valore intero restituisce il valore in ascii del carattere letto
                //car = Convert.ToChar(valchar);
                if (valchar>96 && valchar<123)
                {
                    caratteri = caratteri + Convert.ToChar(valchar);
                }
                else
                {
                    numeri= numeri + Convert.ToChar(valchar);
                }
               
            } while (valchar != 13);
            Console.ReadLine();
            Console.WriteLine($"caratteri:{caratteri}, numeri:{numeri}");
            Console.ReadLine();
            //valchar = Console.Read();
            //car = Convert.ToChar(valchar);
            //Console.WriteLine($"{valchar}:{car} ");
            //valchar = Console.Read();
            //car = Convert.ToChar(valchar);
            //Console.WriteLine($"{valchar}:{car} ");
            //Console.ReadLine();



        }
    }
}
