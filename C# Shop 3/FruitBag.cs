using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Shop_3
{
    public class FruitBag : Product
    {

        private int capacity;
        private string origin;

        public int Capacity
        {
            get { return capacity; }
            set 
            { /*
                if (value + capacity > 5) { capacity = 5; }
                else if (value > 0 ) { capacity = capacity + value; }
                else if (value + capacity )
                */

                if (value > 5) { capacity = 5; }
                else if (value <0) {  capacity = 0; }
                else { capacity = value; }
            }
        }

        public string Origin 
        {   get
            {
                return origin;
            }
        }

        public FruitBag(string name, string description, float price, string origin, int capacity) : base(name, description, price)
        {
            
            this.origin = origin;
            this.Capacity = capacity;
        }


        //METODI

        public void Eat(int fruitsToEat)
        {
            int remain = this.Capacity - fruitsToEat;
            if (remain >= 0)
            {
                this.Capacity = remain;
            }
            else if (remain < 0 )
            {
                this.Capacity = 0;
            }
        }

        public void Fill(int fruits)
        {
            int filled = this.Capacity + fruits;
            if (filled >= 0 && filled <= this.Capacity)
            {
                this.Capacity = filled;
            }
            else if (filled > 5 ) { this.Capacity = 5; }

            
        }

        public void Empty() { this.Capacity = 0; }

        public override string getStringProdotto()
        {
            string stringaProdotto;
            stringaProdotto = base.getStringProdotto();
            stringaProdotto += "Numero Pezzi di Frutta  : " + this.Capacity + "\n" +
                                "Origine : " + this.Origin + "\n";

            return stringaProdotto;

        }







    }
}
