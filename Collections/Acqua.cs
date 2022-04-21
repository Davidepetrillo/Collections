using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop2
{
    internal class Acqua : Prodotto
    {
        private int numeroBottiglie;
        private double litri;
        public string materialeBottiglie;
        public double ph;
        public string sorgente;
        private double maxLitriBottiglia;

        public Acqua(string nome, string descrizione, double prezzo, int iva, int numeroBottiglie, double litri, string materiale, double ph, string sorgente, double maxLitridisponibili) : base(nome, descrizione, prezzo, iva)
        {
            this.numeroBottiglie = numeroBottiglie;
            this.litri = litri;
            this.materialeBottiglie = materiale;
            this.ph = ph;
            this.sorgente = sorgente;
            this.maxLitriBottiglia = litri;
        }

        public void Bevi(double litriCheBevo)
        {
            if (this.litri - litriCheBevo > 0)
            {
                double litriRimasti = this.litri - litriCheBevo;
                this.litri = this.litri - litriCheBevo;
                Console.WriteLine($"Ho bevuto {litriCheBevo} litri");
                Console.WriteLine($"Mi restano {litriRimasti} litri da bere");

            }
            else
            {
                Console.WriteLine("Mi dispiace ma la bottiglia è finita");
                this.litri = 0;
            }
        }

        public void Svuota(double litriCheSvuoto)
        {
            if (litriCheSvuoto >= this.litri)
            {
                Console.WriteLine("Hai svuotato tutta la bottiglia");
            }
            else
            {
                double litriRimasti;
                litriRimasti = this.litri - litriCheSvuoto;
                double litriRimastiArrotondati = Math.Round(litriRimasti, 2);
                this.litri = this.litri - litriCheSvuoto;
                Console.WriteLine($"Ho svuotato {litriCheSvuoto} litri");
                Console.WriteLine($"Mi restano {litriRimastiArrotondati} litri");
            }
        }


        public void Riempi(double litriCheRiempio)
        {
            double bottigliaDopoEssereStataRiempita = this.litri + litriCheRiempio;
            double litriDisponibili;

            if (litriCheRiempio < 0)
            {
                Console.WriteLine($"Nope");
                return;

            }
            else if (bottigliaDopoEssereStataRiempita < maxLitriBottiglia)
            {
                litriDisponibili = bottigliaDopoEssereStataRiempita;
                this.litri = this.litri + litriCheRiempio;
                Console.WriteLine($"Ho riempito la bottiglia con : {litriCheRiempio} litri");
                Console.WriteLine($"Mi restano : {bottigliaDopoEssereStataRiempita} litri");

            }
            else
            {
                Console.WriteLine("Mi dispiace ma hai traboccato");
                litriDisponibili = litri;
            }
        }




        public static void ConvertiInGalloni(double litri)
        {
            const double CostanteDiConversione = 3.785;
            double ConversioneLitriInGalloni = litri * CostanteDiConversione;
            Console.WriteLine($"Galloni: {ConversioneLitriInGalloni} galloni");
        }


        public override void StampaProdotto()
        {
            Console.WriteLine("----- Prodotto -------");
            Console.WriteLine("Codice: " + codice);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Descrizione: " + descrizione);
            Console.WriteLine($"Numero bottiglie: {numeroBottiglie}");
            Console.WriteLine($"Litri: {litri}/bottiglia");
            ConvertiInGalloni(litri);
            Console.WriteLine($"Materiale bottiglie: {materialeBottiglie}");
            Console.WriteLine($"Prezzo: {prezzo} euro");
            Console.WriteLine($"IVA: {iva}%");
            Console.WriteLine($"Prezzo finale: {PrezzoPiuIva(prezzo, iva)} euro");
            Identificativo(codice, nome);
            PadLeft();
            Console.WriteLine("------------------");
        }



    }
}