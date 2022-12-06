using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp_Shop_3.CustomException;

namespace Csharp_shop_3
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

        // Metodo set pH per controllare se fra valori 0 - 14
        public void SetpH(double pH)
            {
            if (pH < 0 || pH > 14) 
                {
                throw new LimitiPhException("Il pH di un liquido non può essere maggiore di 14 o minore di 0;");
                }
            else { this.pH = pH; }
            }
        // Metodo set sorgente con controllo per campo vuoto e relativa exception
        public void SetSorgente(string sorgente)
            {
            if (string.IsNullOrEmpty(sorgente))
                {
                throw new StringaVuotaException("Hai inserito un valore vuoto! Impostalo meglio!");
                }
            else
                {
                this.sorgente = sorgente;
                }
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

        // Metodo per bere con exception se bevuta tutta
        public void beviAcqua(double QuantaAcqua)
            {
            this.litri = this.litri - QuantaAcqua;
            if (this.litri < 0) 
                {
                this.litri = 0;
                throw new BevutaAcquaException("Hai bevuto tutta l'acqua");
                }
            }
        // Metodo per aggiungere con exception se aggiunta troppa
        public void aggiungiAcqua(double QuantaAcqua)
            {
            this.litri = this.litri + QuantaAcqua;
            if (this.litri > 1.5)
                {
                this.litri = 1.5;
                throw new TroppaAcquaException("Hai aggiunto troppa acqua, ora la bottiglia e' piena e hai allagato casa!");
                }
            }

        // Metodo per restituire galloni

        public double converti(double QuantiLitri)
            {
            if (QuantiLitri <= 0)
                {
                throw new ConversioneImpossibileException("Lo strumento e' impostato per convertire solo ed esclusivamente valori interi positivi");
                }
            double LitriAGalloni = QuantiLitri * 3.785;
            Console.WriteLine(QuantiLitri + " L Sono " + LitriAGalloni + " Galloni");
            return LitriAGalloni;
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
