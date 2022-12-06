using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_shop_2
    {
    public class SacchettoDiFrutta : Prodotto
        {
        private string frutta;
        private double peso;


        public SacchettoDiFrutta(string nome, string descrizione, string frutta, double peso, double prezzo, double iva) : base(nome, descrizione, prezzo, iva)
            {
            this.frutta = frutta;
            this.peso = peso;
            }
        //--------------------------------- Metodi Get ---------------------------------

        public string getFrutta()
            {
            return this.frutta;
            }
        public double getPeso()
            {
            return this.peso;
            }

        //--------------------------------- Metodi Get ---------------------------------

        public void setFrutta(string frutta)
            {
            this.frutta = frutta;
            }

        public void setPeso(double peso)
            {
            this.peso = peso;
            }

        // Override Metodo stampa
        public override void stampaTutto()
            {
            Console.WriteLine("---------" + base.getNome() + "---------" + "\n");
            Console.WriteLine("Descrizione: " + base.getDescrizione());
            Console.WriteLine("Tipo di frutta secca : " + this.frutta);
            Console.WriteLine("Peso: " + this.peso + "g");
            Console.WriteLine("Codice Prodotto: " + base.getNumeroProdotto().ToString().PadLeft(8, '0'));
            Console.WriteLine("Prezzo: " + base.getPrezzo() + " Euro");
            Console.WriteLine("Iva prodotto: " + base.getIva() + "%");
            Console.WriteLine("Prezzo con Iva: " + base.prezzoIvato(base.getPrezzo(), base.getIva()) + "\n");
            }
        }
    }
