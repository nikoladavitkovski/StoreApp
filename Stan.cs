using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetApp.Classes
{
    public class Stan
    {
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

        public void GetFlat()
        {
            Console.WriteLine(price);
        }

        public Stan(float price,int numberofflat, bool nearparkingzone)
        {
            this.price = price;
            this.numberofflat = numberofflat;
            this.nearparkingzone = nearparkingzone;
        }

        public string GetPrice(float price,int numberofflat, bool nearparkingzone)
        {
            if(numberofflat > 5)
            {
                Console.WriteLine($"The full price will be {price.ToString()");                
            } else if (nearparkingzone)
            {
                Console.WriteLine($"The full price will be {price.ToString()");
            }
            else
            {
                Console.WriteLine($"The full price will be {price.ToString()");
            }
            return price.ToString();
        }
    }
}
