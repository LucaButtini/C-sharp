using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrendiParole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int valchar;
            char carattere;

            Console.WriteLine("Scrivi una frase (premi 'x' per uscire)");
            
            do
            {
                valchar = Console.Read();
                carattere = Convert.ToChar(valchar);
                if (valchar == ' ')
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(carattere);
                }
            } while (valchar != -1 && carattere != 'x'); //valchar != da -1 serve controllare che non ci siano caratteri da leggere
            Console.ReadLine();
        }
    }
}
