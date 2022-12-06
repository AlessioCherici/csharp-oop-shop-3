using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_shop_3
    {
    public class Elettrodomestico : Prodotto
        {
        private string tipoElettroDomestico;
        private int wattaggio;
        private string classeEnergetica;

        public Elettrodomestico(string nome, string descrizione, string tipoElettroDomestico, int wattaggio, string classeEnergetica, double prezzo, double iva)
            : base(nome, descrizione, prezzo, iva)
            {
            this.tipoElettroDomestico = tipoElettroDomestico;
            this.wattaggio = wattaggio;
            this.classeEnergetica = classeEnergetica;
            }
        //--------------------------------- Metodi Get ---------------------------------

        public string getTipoElettrodomestico()
            {
            return this.tipoElettroDomestico;
            }

        public int getWattaggio()
            {
            return this.wattaggio;
            }

        public string getClasseEnergetica()
            {
            return this.classeEnergetica;
            }

        //--------------------------------- Metodi Set ---------------------------------

        public void setTipoElettrodomestico(string tipoElettroDomestico)
            {
            this.tipoElettroDomestico = tipoElettroDomestico;
            }

        public void setWattaggio(int wattaggio)
            {
            this.wattaggio = wattaggio;
            }

        public void setClasseEnergetica(string classeEnergetica)
            {
            this.classeEnergetica = classeEnergetica;
            }

        // Override Metodo stampa
        public override void stampaTutto()
            {
            Console.WriteLine("---------" + base.getNome() + "---------" + "\n");
            Console.WriteLine("Descrizione: " + base.getDescrizione());
            Console.WriteLine("Tipo di elettrodomestico : " + this.tipoElettroDomestico);
            Console.WriteLine("Wattaggio: " + this.wattaggio + "W");
            Console.WriteLine("Classe energetica: " + this.classeEnergetica);
            Console.WriteLine("Codice Prodotto: " + base.getNumeroProdotto().ToString().PadLeft(8, '0'));
            Console.WriteLine("Prezzo: " + base.getPrezzo() + " Euro");
            Console.WriteLine("Iva prodotto: " + base.getIva() + "%");
            Console.WriteLine("Prezzo con Iva: " + base.prezzoIvato(base.getPrezzo(), base.getIva()) + "\n");
            }
        }
    }
