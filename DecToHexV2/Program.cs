using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToHexV2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dato un numero in base 10 nel range 0-255 convertirlo in base 2.
            const int BARBERA = 1, SOAVE = 2, MERLOT = 3, LUGANA = 4;
            const int COSTOLITROBARBERA = 2, COSTOLITROLUGANA = 10, COSTOLITROMERLOT = 5, COSTOLITROSOAVE = 8;
            const int SPEDIZIONE = 3;
            int scontrino = 0;
            double sconto = 0.10;
            const double capacitaBottiglie = 1.5;
            double litriTotali;
            double totale = 0, parziale = 0, costoBottiglie = 0, bottiglieGiornata = 0, litriGiornata = 0, scontoTotale = 0, contSconto = 0, totaleGiornata = 0, valoreEuroSconto = 0;
            int numeroBottiglie = 0, spedizioniTotali = 0;

            int spedizioniCliente = 0;
            char risposta;



            do
            {
                Console.WriteLine("============================");
                Console.WriteLine("BENVENUTI ALLA TANA DEI GOTI");
                Console.WriteLine("============================");
                Console.WriteLine();
                Console.WriteLine("1- Barbera, costo litro 2 euro");
                Console.WriteLine("2- Soave, costo litro 8 euro");
                Console.WriteLine("3- Merlot, costo litro 3 euro");
                Console.WriteLine("4- Lugana, costo litro 4 euro");



                do
                {
                    Console.WriteLine("Quanti bottiglioni vuole comprare?");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    numeroBottiglie = Convert.ToInt32(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                } while (numeroBottiglie < 0);
                litriTotali = capacitaBottiglie * numeroBottiglie;
                costoBottiglie = COSTOLITROBARBERA * litriTotali;




                if (litriTotali > 45)
                {
                    Console.WriteLine("Litri maggiori di 45, sconto del 10%");

                    valoreEuroSconto = costoBottiglie * sconto;
                    parziale = costoBottiglie - valoreEuroSconto;

                }
                else
                {
                    parziale = costoBottiglie;
                }
                do
                {
                    Console.WriteLine("Vuoi consegna a domicilio? Premere S se sì o N se no");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    risposta = Convert.ToChar(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.White;
                } while (risposta != 'S' && risposta != 'N');


                if (risposta == 'S') //spedizione
                {

                    totale = parziale + SPEDIZIONE;
                    contSconto = COSTOLITROBARBERA * litriTotali;

                    spedizioniCliente++;

                }
                else //senza spedizione
                {

                    totale = parziale;
                    //senza consegna domicilio
                }

                scontrino++;
                bottiglieGiornata = bottiglieGiornata + numeroBottiglie;
                litriGiornata = litriGiornata + litriTotali;
                scontoTotale = scontoTotale + contSconto;
                spedizioniTotali = SPEDIZIONE * spedizioniCliente;
                totaleGiornata = totaleGiornata + totale;



                Console.WriteLine("Siamo a fine giornata? S o N");
                Console.ForegroundColor = ConsoleColor.Yellow;
                risposta = Convert.ToChar(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                Console.WriteLine();
                //scontrino dei clienti 
                Console.WriteLine("========= Tana dei Goti ===========");
                Console.WriteLine($"Barbera n° bottiglioni {numeroBottiglie}, n° litri {litriTotali}");
                Console.WriteLine($"Sconto {sconto}");
                Console.WriteLine("=======================================");
                Console.WriteLine($"Totale parziale {parziale}"); //totale litri-sconto
                Console.WriteLine($"Spese trasporto {SPEDIZIONE}");
                Console.WriteLine("=======================================");
                Console.WriteLine($"Importo totale {totale}");
                Console.WriteLine($"n° scontrino {scontrino}");
                Console.WriteLine("========= Arrivederci ===========");
                Console.WriteLine();
                Console.WriteLine();
            } while (risposta == 'N');

            Console.WriteLine("========= Tana dei Goti ===========");
            Console.WriteLine("========= Chiusura cassa ===========");
            Console.WriteLine($"Barbera n° bottiglioni {bottiglieGiornata}, n° litri {litriGiornata}");
            Console.WriteLine("=======================================");
            Console.WriteLine($"Sconto {scontoTotale}");
            Console.WriteLine($"Spese trasporto {spedizioniTotali}");
            Console.WriteLine("=======================================");
            Console.WriteLine($"Totale incasso {totaleGiornata}");
            Console.WriteLine($"n° scontrini emessi {scontrino}");
            Console.WriteLine("========= Arrivederci ===========");



            Console.ReadLine();
        }
    }
}
