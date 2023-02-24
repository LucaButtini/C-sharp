using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaMaestraInGita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // aiutare la maestra a fare l'appello
            int NumeroStudenti;
            string[] NomeStudenti;
            string NomeBambino;
           // int bambini = 3;
           //inutile usare una costante per il numero di bambini quando il numero viene chiesto all'utente. 
            int BambiniPresenti = 0;
            bool trovato = false;
            // Inserimento bambini
            Console.WriteLine("Quanti alunni ci sono nella classe?");
            NumeroStudenti = Convert.ToInt32(Console.ReadLine());
            NomeStudenti = new string[NumeroStudenti];
            for (int i = 0; i < NumeroStudenti; i++)
            {
                Console.WriteLine($"Inserisci nome dello studente {i + 1}");
                NomeStudenti[i] = Console.ReadLine();
            }
            // Visualizzazione registro di classe
            Console.WriteLine("Registro di classe:");
            for (int i = 0; i < NumeroStudenti; i++)
            {
                Console.WriteLine($"Nome alunno[{i + 1}]: {NomeStudenti[i]}");
            }
            Console.ReadLine();
            // Bambini allo zoo

            do
            {
                Console.WriteLine("Chi sei?");
                NomeBambino = Console.ReadLine();
                trovato = false;
                for (int i = 0; i < NumeroStudenti; i++)
                {

                    if (NomeBambino == NomeStudenti[i])
                    {
                        trovato = true;
                        BambiniPresenti++;
                        Console.WriteLine("Il bambino è presente");
                    }
                   
                }
                if (trovato==false)
                {
                    Console.WriteLine("Il bambino non è presente all'appello");
                }
                


               
            } while (NumeroStudenti != BambiniPresenti);
            // Sono saliti tutti i bambini
            Console.WriteLine("Il pullman è partito");
            Console.ReadLine() ;
        }
        
    }
    }

