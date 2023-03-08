using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioReadInClasse
{
    class Program
    {
        static void Main(string[] args)
        {

            char car;
            int numeri = 0, altriCar = 0;
            char[] alfabeto = new char[26];  //array char per alfabeto  e metto le lettere
            int[] frequenza = new int[26];    //  tutti gli indici array 0

            for (int i = 0; i < 26; i++)//metto tutto a zero
            {
                frequenza[i] = 0;
            }

            for (int i = 0; i < 26; i++)      
            {
                alfabeto[i] = Convert.ToChar(65 + i); // Assegno ad ogni sezione dell'array "alfabeto" un codice asci (convertito in caratere) partendo da 65 (che equivale ad A) ed aggiungengo 1 fino ad arrivare a 90 (che è uguale a Z)
            }

            Console.WriteLine("Inserire una frase:");

            do
            {
                car = Convert.ToChar(Console.Read());

                for (int i = 0; i < 26; i++) //controllo se ce il carattere 
                {
                    if (alfabeto[i] == car) // se car è in alfabeto, la sua frequenza aumenta
                    {
                        frequenza[i]++;
                    }
                }

                if (car >= 48 && car <= 57)
                {
                    numeri++;
                }
                else if (car >= 33 && car <= 47 || car >= 58 && car <= 64 || car >= 91 && car <= 96 || car >= 123 && car <= 126) //ascii dei restanti caratteri, senza lettere alf maiusc, min, numeri.
                {
                    altriCar++;
                }

            } while (car != 13);
            Console.WriteLine($"I numeri all'interno della frase sono {numeri}");
            Console.WriteLine($"I caratteri sono {altriCar}");
            Console.WriteLine("La frequenza di lettere presenti nella frase è: ");
            for (int i = 0; i < 26; i++)
            {
                if (frequenza[i] != 0) 
                {
                    Console.WriteLine($"Lettera {alfabeto[i]}= frequenza[{frequenza[i]}]");
                }
            }

            Console.ReadLine();
            Console.ReadLine();
            
        }
    }
}
