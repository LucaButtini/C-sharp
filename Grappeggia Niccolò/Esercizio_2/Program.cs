using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_2
{
    class Program
    {
        static void Main(string[] args) // Grappeggia Niccolò 3°F Esercizio_2 Fila_a
        {
            // Dichiarazione variabili
            int N, contParole = 0;
            string frase, parola = "";
            bool duplicato = false;
            // Inserimento numero di parole che si vogliono inserire nella frase,
            // e inizializzazione array con lunghezza pari al numero di parole che si desidera inserire
            Console.WriteLine("Quante parole vuole inserire nella frase?");
            N = Convert.ToInt32(Console.ReadLine());
            string[] arrayParole = new string[N];
            // Inserimento frase
            Console.WriteLine("Inserire la frase:");
            frase = Console.ReadLine() + "";
            // Iterazione con do-while che ripete il ciclo quante sono le parole
            do
            {
                // Ciclo che serve a costruire le parole, quando un carattere della frase non è una lettera finisce la parola
                for (int i = 0; i < N; i++)
                {
                    if (Char.IsLetter(frase[i]))
                    {
                        parola = parola + frase[i];
                    }
                    else
                    {
                        arrayParole[i] = parola;
                        parola = "";
                        
                    }
                }
                if (contParole != 0)
                {   // Ciclo che controlla la presenza di duplicati
                    for (int j = 0; j < contParole && !duplicato; j++)
                    {
                        if (arrayParole[j] == arrayParole[j + 1])
                        {
                            duplicato = true;
                        }
                    }
                }
                contParole++;
            } while (contParole < N && !duplicato);

            // Output che varia in base al valore di duplicato
            if (duplicato)
            {
                Console.WriteLine("frase che contiene parola/e duplicate");
            }
            else
            {
                Console.WriteLine("nessun duplicato");
            }

            Console.ReadLine();
        }
    }
}
