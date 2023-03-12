using System;

namespace EsercizioUno
{
    class Program
    {
        static void Main(string[] args) // Matteo Fuso - 3F - Fila B - 11/03/2023
        {
            // Dichiaro e inizializzo le variabili
            // Inizializzo una variabile di tipo random
            Random random = new Random();
            // Valori contine quanti numeri devono essere generati, cifra l'ultima cifra quando si scompone il numero,
            // numero il numero generate randomicamente e i l'indice dei due cicli per non dichiararlo due volte
            int valori, cifra, numero, i;
            // Vettore che contiene la frequenza delle cifre
            int[] frequenza = new int[10];
            // Chiedo quanti valori vuole generare finchè non è accettabile (> 0)
            do
            {
                Console.Write("Inserisci quanti numeri vuoi generare: ");
                valori = Convert.ToInt32(Console.ReadLine());
            } while (valori < 1);
            Console.WriteLine();
            // Genero i numeri e conto la frequenza delle cifre
            for (i = 0; i < valori; i++)
            {
                // Genero un numero random nell'intervallo 100-200 compresi e lo stampo
                numero = random.Next(100, 201);
                Console.WriteLine("Valore random: {0}", numero);
                // Scompongo il numero utilizzando l'operatore mod che ritorna il resto della divisione e nel caso del 10 l'ultima cifra,
                // aggiorno il contatore. Utilizzo numero come intero così appena faccio la divisione tralascia il resto.
                // Faccio questo ciclo finchè il numerò sarà diventato zero quindi non ha più cifre da scomporre
                do
                {
                    // Ottengo l'ultima cifra
                    cifra = numero % 10;
                    // Aggiorno il contatore
                    frequenza[cifra]++;
                    // Tolgo l'ultima cifra
                    numero = numero / 10;
                } while (numero != 0);
            }
            Console.WriteLine();
            // Ciclo tutto l'array e se il valore non è zero, stampo la frequenza
            for (i = 0; i < frequenza.Length; i++)
            {
                if (frequenza[i] != 0)
                {
                    Console.WriteLine("Il numero {0} è presente {1} volta/e", i, frequenza[i]);
                }
            }
            Console.WriteLine();
            // Aspetto la pressione di un tasto per l'uscita dal programma
            Console.Write("Premi un tasto per uscire . . .");
            Console.ReadKey();
        }
    }
}