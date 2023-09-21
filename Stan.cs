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

        public int numberofflat;

        public bool nearparkingzone;

        public Stan(int numberofflat, bool nearparkingzone)
        {
            this.numberofflat = numberofflat;
            this.nearparkingzone = nearparkingzone;
        }

        public string Value(int numberofflat, bool nearparkingzone)
        {
            if(numberofflat > 5)
            {
                Console.WriteLine("The price is 10% lower");                
            } else if (nearparkingzone)
            {
                Console.WriteLine("The price is 5% higher");
            }
            else
            {
                Console.WriteLine("The price is 3% higher");
            }
            return numberofflat.ToString();
        }
    }
}
