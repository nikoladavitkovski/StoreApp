using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GadgetApp.Classes
{
    class Houses : Nedvizen_Imot
    {
        public Houses(float price,int numberofflats, bool primaryschoolnear, int squares, string address) : base(address,price,squares)
        {
            this.price = price;
            this.numberofflats = numberofflats;
            this.primaryschoolnear = primaryschoolnear;
        }
    
        public float price;

        public List<DateTime> dates = new List<DateTime>()
        {
            new DateTime(2022,12,07)
        };
        
        public int numberofflats;

        public bool primaryschoolnear;

        public override string GetPrice()
        {
            if (primaryschoolnear)
            {
                this.price = (float)(this.price + (this.price * 0.03));
            }
            return this.price();
        }
    }
}
