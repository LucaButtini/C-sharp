using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vinaioparte5
{
    class Program
    {
        static void Main(string[] args)
        {
            //TANA DEI GOTI

            //dichiarazione variabili
            const int costoLitro = 2;
            const int spedizione = 3;
            const double sconto = 0.1;
            const double capacitaBottiglie = 1.5;
            float totale, parziale;
            int numeroBottiglie=0, numeroLitri=0;

            //input dati
            Console.WriteLine("BENVENUTI ALLA TANA DEL VINAIO");

            //mettere il controllo che i litri siano maggiori di 0
            do
            {
                Console.WriteLine("Quanti bottiglioni di Barbera vuole comprare?");
                numeroBottiglie = Convert.ToInt32(Console.ReadLine());
                else
                {
                    Console.WriteLine("Reinserisci il numero");
                }
            } while (numeroBottiglie > 0);
            Console.ReadLine();
        }
    }
}
