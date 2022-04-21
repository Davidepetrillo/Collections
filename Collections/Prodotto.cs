using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpShop2
{
    internal class Prodotto
    {
        private protected long codice;
        private protected string nome;
        private protected string descrizione;
        private protected double prezzo;
        private protected int iva;


        public Prodotto(string nome, string descrizione, double prezzo, int iva)
        {
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
            Random random = new Random();
            codice = random.Next(1000);
        }

        public string GetCodice()
        {
            string codiceConIlPadding;
            codiceConIlPadding = PadLeft();
            return codiceConIlPadding;
        }

        // ----- Fare getter e setter di tutte le variabili -----

        public string GetNome(string nuovoNome)
        {
            return nuovoNome;
        }
        public string SetNome(string nuovoNome)
        {
            return nuovoNome;
        }
        public string GetDescrizione(string nuovaDescrizione)
        {
            return nuovaDescrizione;
        }
        public string SetDescrizione(string nuovaDescrizione)
        {
            return nuovaDescrizione;
        }

        public double GetPrezzo(double nuovoPrezzo)
        {
            return nuovoPrezzo;
        }
        public double SetPrezzo(double nuovoPrezzo)
        {
            return nuovoPrezzo;
        }

        public int GetIva(int nuovoIva)
        {
            return nuovoIva;
        }


        public double PrezzoPiuIva(double prezzo, int iva)
        {
            double prezzoFinale = prezzo + ((prezzo * iva) / 100);
            double prezzoFinaleArrotondato = Math.Round(prezzoFinale, 2);
            return prezzoFinaleArrotondato;
        }

        public void Identificativo(long codice, string nome)
        {
            Console.WriteLine($"Codice identificativo: {codice}-{nome}");
        }

        private protected string PadLeft()
        {
            string codiceString = codice.ToString();
            char zero = '0';
            return codiceString.PadLeft(8, zero);
        }

        public virtual void StampaProdotto()
        {
            Console.WriteLine("----- Prodotto -------");
            Console.WriteLine("Codice: " + codice);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Descrizione: " + descrizione);
            Console.WriteLine($"Prezzo: {prezzo} euro");
            Console.WriteLine($"IVA: {iva}%");
            Console.WriteLine($"Prezzo finale: {PrezzoPiuIva(prezzo, iva)} euro");
            Console.WriteLine($"Codice esteso: {PadLeft()}");
            Identificativo(codice, nome);
            Console.WriteLine("------------------");

        }

    }
}