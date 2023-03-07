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
            int numeroBambini, contaBambini = 0, i = 0, y = 0;
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
                                Console.Clear();
                                Console.WriteLine($"Inserisci il nome del bambino {i + 1}");
                                bambino = Console.ReadLine();
                                presente = false;
                                for (int h = 0; h < i; h++)
                                {
                                    if (bambino == classe[h])
                                    {
                                        presente = true;
                                        break;
                                    }
                                }
                                if (presente)
                                {
                                    Console.WriteLine($"Il bambino {bambino} è già presente nel registro.");
                                }
                                else
                                {
                                    classe[i] = bambino;
                                    i++;
                                    contaBambini++;
                                    Console.WriteLine($"Il bambino {bambino} è stato inserito nel registro.");
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Hai già inserito tutti i bambini nella classe");
                            }
                        }
                        break;
                    case 2:
                        {
                            Console.Clear();


                            Console.WriteLine($"Nome alunno[{y + 1}]: {classe[y]}");
                            y++;
                        }
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Ricerca");
                            Console.WriteLine();
                            Console.WriteLine("Come ti chiami?");
                            bambino = Console.ReadLine();
                            presente = false;

                            for (int h = 0; h < numeroBambini && !presente; h++)
                            {
                                presente = bambino == classe[h];
                                //if (alunno == alunni[i])
                                //{
                                //    trovato = true;

                                //}


                            }
                            if (presente)
                            {
                                Console.WriteLine("Studente trovato");
                            }
                            else
                            {
                                Console.WriteLine("Studente non presente");
                            }
                        }
                        break;
                    case 4:
                        {

                            //Console.WriteLine("Non ancora implementata, seleziona un'altra opzione");
                            Console.Clear();
                            Console.WriteLine("Inserisci il nome del bambino di cui vuoi conoscere la posizione");
                            bambino = Console.ReadLine();
                            presente = false;
                            int posizione = -1;
                            for (int h = 0; h < contaBambini && !presente; h++)
                            {
                                presente = bambino == classe[h];
                                if (presente)
                                {
                                    posizione = h + 1;
                                }
                            }
                            if (posizione != -1)
                            {
                                Console.WriteLine($"Il bambino {bambino} si trova in posizione {posizione} del registro");
                            }
                            else
                            {
                                Console.WriteLine("Bambino non presente nel registro");
                            }
                        }
                        break;
                }
            } while (scelta != 5);
        }
    }
}
