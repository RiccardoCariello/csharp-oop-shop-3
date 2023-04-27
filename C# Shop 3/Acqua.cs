
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Shop_3
{
   

        public class Acqua : Product
        {
            //ATTRIBUTI

            private float liters;
            private float ph;
            private string source;


            //PROPERTY
            public float Liters
            {
                get
                {
                    return liters;
                }
                set
                {
                    if (value > 1.5f)
                    {
                        this.liters = 1.5f;

                    }
                    else if (value < 0)
                    {
                        this.liters = 0;
                    }
                    else
                    {
                        this.liters = value;
                    }
                }
            }

            public float Ph
            {
                get
                {
                    return ph;
                }
            }

            public string Source
            {
                get { return source; }

            }


            //COSTRUTTORE
            public Acqua(string name, string description, float price, float liters, float ph, string source, int iva = 22) : base(name, description, price, iva)
            {
                this.Liters = liters;
                this.ph = ph;
                this.source = source;

            }


            //metodiniii

            public void Drink(float litersToDrink)
            {
                if (litersToDrink > this.liters)
                {
                    this.liters = 0;
                }
                else if (litersToDrink > 0 && litersToDrink <= 1.5f)
                {
                    this.liters = this.liters - litersToDrink;
                }
            }

            public void Fill(float liters)
            {

                if ((liters > 0) && (liters <= 1.5f))
                {
                    this.liters = this.liters + liters;
                }

                if (this.liters > 1.5f) { this.liters = 1.5f; }
            }

            public void Empty() { this.liters = 0; }

            public override string getStringProdotto()
            {
                string stringaProdotto;
                stringaProdotto = base.getStringProdotto();
                stringaProdotto += "Litri : " + this.liters + "\n" +
                    "Ph : " + this.ph + "\n" +
                    "Sorgente : " + this.source + "\n";

                return stringaProdotto;

            }



        }
    }

