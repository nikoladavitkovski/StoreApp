using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetApp.Classes
{
    public class Houses
    {
        public int numberofflats;

        public bool primaryschoolnear;

        public Houses(int numberofflats, bool primaryschoolnear)
        {
            this.numberofflats = numberofflats;
            this.primaryschoolnear = primaryschoolnear;
        }

        public string FullArea(float price, int square)
        {
            if (price * square == 3600)
            {
                Console.WriteLine($"The maximum will be {square.GetType()}");
            }

            if (primaryschoolnear)
            {
                Console.WriteLine("The price is 3% higher");
            }
            return price.ToString();
        }
    }
}
