﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Shop_3
{
    public class Product
    {


        private protected int code;
        public int Code
        {
            get
            {
                return code;
            }
        }


        private protected string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        private protected string description;
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        private protected float price;
        public float Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value > 0)
                {
                    this.price = value;
                }
            }
        }

        private protected int tax;
        public int Tax
        {
            get
            {
                return tax;
            }
            set
            {
                tax = value;
            }
        }

        private protected float priceWithTax;
        public float PriceWithTax
        {
            get
            {
                return priceWithTax;
            }
            set
            {
                priceWithTax = value;
            }
        }

        //MAGIMAGIA
        private protected Category categoria; // { get; }

        //CONSTRUCTOR
        public Product(string name, string description, float price, int iva = 22, string nomecategoria = "alimentare")
        {

            this.name = name;
            this.description = description;
            this.price = price;
            this.code = RandomGen();
            this.tax = iva;
            
            this.categoria = new Category(nomecategoria);

        }

        public void ResettaPrezzo()
        {
            this.price = 0;
        }

        //METHODS

        private int RandomGen() //questo metodo dovrebbe generare un random int e poi restituirlo
        {
            Random rnd = new Random();
            int numeroCifre = rnd.Next(1, 9);

            int codeInt = 0;

            switch (numeroCifre)
            {
                case 1:
                    codeInt = rnd.Next(1, 10);
                    break;
                case 2:
                    codeInt = rnd.Next(10, 100);
                    break;
                case 3:
                    codeInt = rnd.Next(100, 1000);
                    break;
                case 4:
                    codeInt = rnd.Next(1000, 10000);
                    break;
                case 5:
                    codeInt = rnd.Next(10000, 1000000);
                    break;
                case 6:
                    codeInt = rnd.Next(100000, 1000000);
                    break;
                case 7:
                    codeInt = rnd.Next(1000000, 10000000);
                    break;
                case 8:
                    codeInt = rnd.Next(10000000, 100000000);
                    break;

            }

            return codeInt;

        }

        public string FormattedNum()// questro metodo formatta il numero dato e ci aggiunge 0 alla sinistra fino a raggiungere un massimo di 8 cifre
        {
            int padding = 0;
            padding = Code.ToString().Length;
            padding = 8 - padding;
            string zeros = "";

            for (int i = 0; i < padding; i++)
            {
                zeros += "0";

            }

            zeros = zeros + Code;
            return zeros;

        }

        public string getFormattedCodePadLeft8()
        {
            string codeString = this.code.ToString();
            string codeStringPadded = codeString.PadLeft(8, '0');
            return codeStringPadded;

        }

        public string CodeName() // ritorna una stringas con il codice formattato concatenato al nome.
        {
            string codeName = FormattedNum() + Name;
            return codeName;
        }

        public virtual string getStringProdotto()
        {
            string rappresentazioneInStringa = "\n\nNome prodotto: " + this.name + "\n";
            rappresentazioneInStringa += "Descrizione prodotto: " + this.description + "\n";
            rappresentazioneInStringa += "Prezzo prodotto: " + this.price + "euro \n";
            rappresentazioneInStringa += "Iva prodotto: " + this.tax + "%\n";
            rappresentazioneInStringa += "Categoria prodotto: \n " + categoria.StampaInfoCodice() + "\n";


            return rappresentazioneInStringa;
        }



        public float GetPrezzoBase() // prezzo semplice
        {
            return price;
        }

        public float GetPrezzoIva() //prezzo con l'iva
        {
            float iva = (price * tax) / 100;
            return price + iva;
        }

    }
}
