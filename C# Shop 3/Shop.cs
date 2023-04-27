
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Shop_3
{
    public class Shop
    {


        //ATTRIBUTI

        private string nome;
        private string citta;
        private string addressN;
        private int numeroCivico;

        //PROPERTY

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                this.nome = value;
            }
        }
        public string Citta
        {
            get
            {
                return citta;
            }
        }
        public string Indirizzo
        {
            get
            {
                return addressN;
            }
        }

        public int NumeroCivico
        {
            get
            {
                return numeroCivico;
            }
        }

        List<Product> listaProdotti;

        //COSTRUTTORE

        public Shop(string nome, string citta, string indirizzo, int numeroCivico)
        {
            this.nome = nome;
            this.citta = citta;
            this.numeroCivico = numeroCivico;
            this.addressN = indirizzo;

            this.listaProdotti = new List<Product>();

        }



        //METHODS

        public void SetList(List<Product> ListaProdottiDaAggiungere)
        {
            foreach (Product ProdottodaAggiungere in ListaProdottiDaAggiungere)
            {
                this.listaProdotti.Add(ProdottodaAggiungere);
            }
        }

        public void AggiungereProdotto(Product prodotto)
        {
            this.listaProdotti.Add(prodotto);
        }

        public string ListaProdotti() //ritorna una stringa con tutti i prodotti nella lista del negozio
        {
            //ritorna una stringa con tutti i prodotti nella lista del negozio
            string prodotti = "";
            foreach (Product item in this.listaProdotti)
            {

                prodotti += item.getStringProdotto() + "\n\n";

            }
            return prodotti;
        }

        public string getStringNegozio()
        {
            string rappresentazioneInStringa = "\nNome negozio : " + this.Nome + "\n";
            rappresentazioneInStringa += "Città del Negozio: " + this.Citta + "\n";
            rappresentazioneInStringa += "Indirizzo del negozio : " + this.Indirizzo + "\n";
            rappresentazioneInStringa += "Civico del negozio: " + this.NumeroCivico + "\n\n";



            return rappresentazioneInStringa;
        }


        public int NumberOfItems()
        {
            return listaProdotti.Count;
        }
    }
}
