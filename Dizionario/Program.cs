using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dizionario
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, y;
            string parola = "";
            char car;
            string[] dizionario = new string[4];
            bool presente;
            Console.WriteLine("Inserisci le parole da inserire nel dizionario: ");
            do
            {
                car = Convert.ToChar(Console.Read());
                if (car != '\r' && car != ' ')
                {
                    parola = parola + car;
                }
                else if (cont < 4)
                {
                    y = 0;
                    presente = false;
                    do
                    {
                        if (parola == dizionario[y])
                        {
                            presente = true;
                            Console.WriteLine($"La parola {parola} è già all'interno del dizionario");
                        }
                        else
                        {
                            dizionario[cont] = parola;
                        }
                        y++;
                    } while (y < cont && presente == false);
                    cont++;
                    parola = "";
                }
            } while (car != '\r');
            for (int i = 0; i < cont; i++)
            {
                Console.WriteLine(dizionario[i]);
            }
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
