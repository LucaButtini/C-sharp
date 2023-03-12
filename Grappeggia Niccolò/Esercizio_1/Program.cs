using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_1
{
    class Program
    {
        static void Main(string[] args) // Grappeggia Niccolò 3°F Esercizio 1 Fila A
        {   // Dichiarazione variabili e costanti
            const int max = 10;
            int N, casuale, cifra, cont = 0;
            Random nrg = new Random();
            int[] frequenzaCifre = new int[max];
            // Input numeri casuali da generare
            Console.WriteLine("Quanti numeri casuali vuoi stampare?");
            N = Convert.ToInt32(Console.ReadLine());
            // Ciclo che genera i numeri casuali da 0 - 100 e controllo frequenza cifre
            for (int i = 0; i < N; i++)
            {
                casuale = nrg.Next(0, 101);
                
                cifra = casuale % 10;
                casuale = casuale / 10;
                frequenzaCifre[cifra]++;
                while (casuale != 0)
                {
                    cifra = casuale % 10;
                    casuale = casuale / 10;
                    frequenzaCifre[cifra]++;
                }
            }
            // Ciclo per stampare l'array di frequenza
            for (int j = 0; j < max; j++)
            {
                if (frequenzaCifre[j] != 0)
                {
                    Console.WriteLine($"[{cont}] = {frequenzaCifre[j]}");
                }
                cont++;
            }
            // Blocco il programma
            Console.ReadLine();
        }
    }
}
