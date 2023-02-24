using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaScuolaElementareMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroBambini, contaBambini = 0, contaPresenti = 0;
            bool presente;
            int scelta = 0;
            string bambino;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("============================");
            Console.WriteLine("LA SCUOLA ELEMENTARE");
            Console.WriteLine("============================");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Inserire il numero di bambini");
            numeroBambini = Convert.ToInt32(Console.ReadLine());
            string[] classe = new string[numeroBambini];


            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Quale opzione vuoi scegliere?");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[1] inserimento, [2] presenti, [3] ricerca,  [4] ricerca posizione alunno/ registro, [5] esci");
                scelta = Convert.ToInt32(Console.ReadLine());
                switch (scelta)
                {
                    case 1:
                        {
                            if (contaBambini != numeroBambini)
                            {
                                for (int i = 0; i < numeroBambini; i++)
                                {
                                    Console.WriteLine($"Inserisci il nome del bambino {i + 1}");
                                    classe[i] = Console.ReadLine();
                                    Console.WriteLine($"Nome alunno[{i + 1}]: {classe[i]}");
                                    contaBambini++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Hai già inserito tutti i bambini nella classe");
                            }
                        }
                        break;
                    case 2:
                        {
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
                                        contaPresenti++;
                                        Console.WriteLine("Il bambino è presente");
                                    }

                                }
                                if (presente == false)
                                {
                                    Console.WriteLine("Il bambino non è presente");
                                }
                            } while (numeroBambini != contaPresenti);
                            // Sono saliti tutti i bambini
                            Console.WriteLine("Tutti gli alunni sono presenti.");
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Non ancora implementata, seleziona un'altra opzione");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Non ancora implementata, seleziona un'altra opzione");
                        }
                        break;
                }
            } while (scelta != 5);
        }
    }
}
