
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

            private double liters;
            private float ph;
            private string source;
            public static double ACQUA_GALLONI = 3.785;

            //PROPERTY
            public double Liters
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
            public Acqua(string name, string description, float price, double liters, float ph, string source, int iva = 22) : base(name, description, price, iva)
            {
                if (liters > 1.5 || liters < 0) 
                { throw new Exception("Una bottiglia d'acqua non può avere più di 1.5 litri nè meno di 0"); }
                else
                {
                    this.Liters = liters;
                }
                
                if(ph > 10 || ph<0)
                {
                    throw new Exception("\nIl ph non può essere nè negativo n'è maggiore di 10\n");
                }else {
                this.ph = ph;
                }
            
            
                
                this.source = source;

            }


            //metodiniii

            public void Drink(double litersToDrink)
            {
                if (litersToDrink > this.liters)
                {

                throw new Exception("Non puoi bere più acqua di quanta ce n'è nella bottiglia");
                }
                else if (litersToDrink > 0 && litersToDrink <= this.liters)
                {
                    this.liters = this.liters - litersToDrink;
                }
            }

            public void Fill(double liters)
            {

                if ((liters > 0) && (liters <= 1.5f))
                {
                   this.liters = this.liters + liters;
                }else 
                {
                    throw new Exception("L'acqua che stai cercando di inserire è troppa o troppo poca");
                }

                if (this.liters > 1.5f ) 
                { 
                    //this.liters = 1.5f;
                    //Console.WriteLine("Un po' di acqua è andata sprecata :(");
                    throw new Exception("L'acqua che stai cercando di inserire è più della capienza massima della bottiglia");
                }
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

        public static double ConvertToGallon(double liters)
        {
            double gallons;
            gallons = liters * ACQUA_GALLONI;
            return gallons;
        }

        }
    }

