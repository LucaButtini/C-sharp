using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversioneHex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valore; // valore inserito dall'utente
            int resto; // resto della divisione per la base
            const int base16 = 16; // base di conversione
            string convertito = ""; // numero convertito
            string restoString = ""; // per convertire convertito in stringa
            string[] lettereHex = new string[6]; //array contenente le lettere 
            // assegno ai valori dell'array le lettere 
            lettereHex[0] = "A";
            lettereHex[1] = "B";
            lettereHex[2] = "C";
            lettereHex[3] = "D";
            lettereHex[4] = "E";
            lettereHex[5] = "F";
            do
            {
                Console.WriteLine("Inserire valore di massimo un byte (255)");
                valore = Convert.ToInt32(Console.ReadLine());
            }
            while (valore < 0 || valore > 255);
            while (valore != 0)
            {
                resto = valore % base16;
                valore = valore / base16; // scompongo il numero
                //converto resto in stringa e lo verifico per assegnarli una lettera
                restoString = Convert.ToString(resto);
                switch (resto) //da 10 a 15 sono le lettere in base hex
                {
                    case 10:
                        restoString = lettereHex[0];
                        break;
                    case 11:
                        restoString = lettereHex[1];
                        break;
                    case 12:
                        restoString = lettereHex[2];
                        break;
                    case 13:
                        restoString = lettereHex[3];
                        break;
                    case 14:
                        restoString = lettereHex[4];
                        break;
                    case 15:
                        restoString = lettereHex[5];
                        break;
                }
                convertito = restoString + convertito;  // scrivo il numero convertito
            }
            Console.WriteLine("Il numero converito in base {0} è {1:0000000}", base16, convertito);//mi scrive il risultato sopra gli zeri
            Console.ReadLine();
        }
    }
}
