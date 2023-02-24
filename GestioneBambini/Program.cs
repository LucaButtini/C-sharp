using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneBambini
{
    class Program
    {
        static void Main(string[] args)
        {
            //creare un programma che permetta di gestire i bambini della maestra.  Il programma deve aiutare a fare l'appello.
            //Il registro deve contenere N bambini (cognome, nome). All'inizio dobbiamo dire quanti bambini ci sono. 


            int numeroBambini, bambiniPresenti = 0;
            string bambino = "";
            bool presente;
            Console.WriteLine("Inserire il numero di bambini");
            numeroBambini = Convert.ToInt32(Console.ReadLine()); //questo determinerà la lenght array
            string[] classe = new string[numeroBambini];

            // inserimento bambini
            for (int i = 0; i < numeroBambini; i++)
            {
                Console.WriteLine($"Inserisci il nome del bambino {i + 1}");
                  classe[i] = Console.ReadLine();
                Console.WriteLine($"Nome alunno[{i + 1}]: {classe[i]}");
            }
            // Bambini allo zoo
            

            do
            {
                presente = false;
                Console.WriteLine("Chi sei?");
                bambino = Console.ReadLine();
                for (int i = 0; i < numeroBambini; i++)
                {                     

                    if (bambino == classe[i])
                    {
                        presente = true;
                        bambiniPresenti++;
                        Console.WriteLine("Il bambino è presente");
                    }

                }
                if (presente == false)
                {
                    Console.WriteLine("Il bambino non è presente");
                }
            } while (numeroBambini != bambiniPresenti);
            // Sono saliti tutti i bambini
            Console.WriteLine("Tutti gli alunni sono presenti, il pullman può partire.");
            Console.ReadLine();
        }
    }
}
