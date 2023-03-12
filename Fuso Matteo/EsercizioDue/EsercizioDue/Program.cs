using System;

namespace EsercizioDue
{
    class Program
    {
        static void Main(string[] args) // Matteo Fuso - 3F - Fila B - 11/03/2023
        {
            // Dichiaro e iniziallizzo le variabili: lungheza è la lunghezza del vettore dizionario, paroleInserite indica quante parole ci sono dentro,
            // i e j sono indici di cicli per non dichiararli più volte durante l'esecuzione
            int lunghezza, paroleInserite = 0, i, j;
            // frase contiene la frase inserita dall'utente, buffer contine la parola che viene piano a piano composta
            string frase, buffer = "";
            // esci è utilizzato nei cicli per uscire nel caso le prossime iterazioni siano inutili oppure per controllare se la parola è già presente nel dizionario
            bool esci = false;
            // Chiedo la lunghezza del dizionario finchè non è accettabile (>0)
            do
            {
                Console.Write("Inserisci la lunghezza del dizionario: ");
                lunghezza = Convert.ToInt32(Console.ReadLine());
            } while (lunghezza < 1);
            // Creo il vettore dizionario
            string[] dizionario = new string[lunghezza];
            Console.WriteLine();
            // Chiedo la frase
            Console.WriteLine("Inseri la frase: ");
            frase = Console.ReadLine();
            // Aggiungo uno spazio alla fine perchè tutte le parole sono divise da uno spazio tranne l'ultima
            frase += " ";
            // Siccome una stringa è un array di caratteri posso utilizzarla per iterare ogni carattere
            for (i = 0; i < frase.Length && !esci; i++)
            {
                // Controllo se sono in presenza di una parola
                if (frase[i] == ' ')
                {
                    // Controllo se il buffer è vuoto così da non aggiungere parole vuote nel dizionario
                    if (buffer != "")
                    {
                        // Trasformo la parola in caratteri minuscoli per non differire parole che in realtà sono uguali
                        buffer = buffer.ToLower();
                        // Assegno ad esci false, come se non avesse trovata to la parola e ciclo l'array per controllare se la parola è già presente
                        // Ciclo con la variabile paroleInserite per non controllare parti dell'array che sono vuote
                        esci = false;
                        for (j = 0; j < paroleInserite && !esci; j++)
                        {
                            // Controllo se in questa posizione dell'array ho trovato la parola e nel caso esco
                            esci = dizionario[j] == buffer;
                        }
                        // Controllo se non ho trovato la parola
                        if (!esci)
                        {
                            // Controllo se il dizionario è pieno
                            if (paroleInserite < dizionario.Length)
                            {
                                dizionario[paroleInserite] = buffer;
                                paroleInserite++;
                            }
                        }
                        // Controllo se il dizionario è pieno con l'ultimo inserimento e azzero il buffer
                        esci = paroleInserite == dizionario.Length;
                        buffer = "";
                    }
                }
                else
                {
                    // Aggiungo la lettera al mio buffer
                    buffer += frase[i];
                }
            }
            Console.WriteLine();
            // Stampo il mio dizionario
            // Ciclo con la variabile paroleInserite per non stampare parti dell'array che sono vuote
            Console.WriteLine("Ecco il dizionario: ");
            for (i = 0; i < paroleInserite; i++)
            {
                Console.WriteLine(dizionario[i]);
            }
            Console.WriteLine();
            // Aspetto la pressione di un tasto per la chiusura del programma
            Console.WriteLine("Premi un tasto per uscire . . .");
            Console.ReadKey();
        }
    }
}