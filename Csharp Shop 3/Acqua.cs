using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_shop_2
    {
    public class Acqua : Prodotto
        {
        private double litri;
        private double pH;
        private string sorgente;

        public Acqua(string nome, string descrizione, double litri, double pH,
            string sorgente, double prezzo, double iva) : base(nome, descrizione, prezzo, iva)
            {
            this.litri = litri;
            this.pH = pH;
            this.sorgente = sorgente;
            }

        //--------------------------------- Metodi Get ---------------------------------

        public double GetLitri()
            {
            return this.litri;
            }
        public double GetpH()
            {
            return this.pH;
            }
        public string GetSorgente()
            {
            return this.sorgente;
            }
        //--------------------------------- Metodi set ---------------------------------

        public void SetLitri(double litri)
            {
            this.litri = litri;
            }
        public void SetpH(double pH)
            {
            this.pH = pH;
            }
        public void SetSorgente(string sorgente)
            {
            this.sorgente = sorgente;
            }

        //--------------------------------- Metodi Acqua ---------------------------------

        public void svuotaBottiglia()
            {
            this.litri = 0;
            }

        public void riempiBottiglia()
            {
            this.litri = 1.5;
            }

        public void beviAcqua()
            {
            this.litri = this.litri - 0.3;
            }

        public void refillBottigliaUtente(double acquaInserita)
            {
            if (acquaInserita < 0)
                {
                Console.WriteLine("Non puoi piu rimuovere un valore negativo di acqua, tonto!");
                }
            else if (acquaInserita > 0 && acquaInserita <= 1.5 && this.litri + acquaInserita < 1.5)
                {
                this.litri += acquaInserita;
                }
            else
                {
                Console.WriteLine("Hai inserito troppa acqua!");
                }
            }

        // Override Metodo stampa
        public override void stampaTutto()
            {
            Console.WriteLine("---------" + base.getNome() + "---------" + "\n");
            Console.WriteLine("Descrizione: " + base.getDescrizione());
            Console.WriteLine("Capienza: " + this.litri + "L");
            Console.WriteLine("pH: " + this.pH);
            Console.WriteLine("Sorgente: " + this.sorgente);
            Console.WriteLine("Codice Prodotto: " + base.getNumeroProdotto().ToString().PadLeft(8, '0'));
            Console.WriteLine("Prezzo: " + base.getPrezzo() + " Euro");
            Console.WriteLine("Iva prodotto: " + base.getIva() + "%");
            Console.WriteLine("Prezzo con Iva: " + base.prezzoIvato(base.getPrezzo(), base.getIva()) + "\n");
            }


        }
    }
