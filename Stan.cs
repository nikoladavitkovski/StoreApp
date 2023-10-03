using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetApp.Classes
{
    class Stan : Houses
    {
        public Stan(float price,int numberofflat, bool nearparkingzone,int squares,string address) : base(address,price,squares)
        {
            this.price = price;
            this.numberofflat = numberofflat;
            this.nearparkingzone = nearparkingzone;
        }) 
        
        public List<Stan> stanovi = new List<Stan>()
        {
            
        };

        public List<DateTime> dates = new List<DateTime>()
        {
            new DateTime(2022,12,14)
        };

        public float price;

        public int numberofflat;

        public bool nearparkingzone;

        public override string GetPrice()
        {
            if(numberofflat > 5)
            {
                this.price = (float)(this.price - (this.price * 0.1));
            } else if (nearparkingzone)
            {
                this.price = (float)(this.price - (this.price * 0.05));
            }
            return this.price;
        }
    }
}
