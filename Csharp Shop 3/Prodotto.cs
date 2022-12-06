using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_shop_2
    {
    public class Prodotto
        {
        private string Nome;
        private int NumeroProdotto;
        private string Descrizione;
        private double Prezzo;
        private double Iva;

        public Prodotto(string nome, string descrizione, double prezzo, double iva)
            {
            this.Nome = nome;
            this.NumeroProdotto = generatoreRGN();
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Iva = iva;
            }



        //------------------------- Metodi Get -------------------------

        public double getPrezzo()
            {
            return this.Prezzo;
            }

        public string getNome()
            {
            return this.Nome;
            }

        public int getNumeroProdotto()
            {
            return NumeroProdotto;
            }

        public double getIva()
            {
            return this.Iva;
            }

        public string getDescrizione()
            {
            return this.Descrizione;
            }

        //------------------------- Metodi Set -------------------------


        public void setPrezzo(double Prezzo)
            {
            this.Prezzo = Prezzo;
            }

        public void setDescrizione(string Descrizione)
            {
            this.Descrizione = Descrizione;
            }

        public void setNome(string Nome)
            {
            this.Nome = Nome;
            }

        public void setIva(double Iva)
            {
            this.Iva = Iva;
            }


        //------------------------- Metodi Calcoli Vari -------------------------
        public int generatoreRGN()
            {
            Random NumeroRNGProdotto = new Random();
            int CodiceProdotto = NumeroRNGProdotto.Next(100000000);
            return CodiceProdotto;
            }
        public double prezzoIvato(double Prezzo, double Iva)
            {
            double ValoreIva = Prezzo * Iva / 100;
            double PrezzoIvato = Prezzo + ValoreIva;
            return Math.Round(PrezzoIvato, 2);
            }

        //------------------------- Metodo Stampa Prodotto -------------------------

        public virtual void stampaTutto()
            {
            Console.WriteLine("---------" + this.Nome + "---------" + "\n");
            Console.WriteLine("Descrizione: " + this.Descrizione);
            Console.WriteLine("Codice Prodotto: " + this.NumeroProdotto.ToString().PadLeft(8, '0'));
            Console.WriteLine("Iva prodotto: " + this.Iva + "%");
            Console.WriteLine("Prezzo con Iva: " + prezzoIvato(this.getPrezzo(), this.getIva()) + "\n");
            }
        }
    }
