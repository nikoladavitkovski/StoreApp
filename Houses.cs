using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GadgetApp.Classes
{
    public class Houses
    {
        public float price;

        public List<DateTime> dates = new List<DateTime>()
        {
            new DateTime(2022,12,07)
        };
        
        public int numberofflats;

        public bool primaryschoolnear;

        public void GetHouse()
        {
            Console.WriteLine(price);
        }

        public Houses(float price,int numberofflats, bool primaryschoolnear)
        {
            this.price = price;
            this.numberofflats = numberofflats;
            this.primaryschoolnear = primaryschoolnear;
        }

        public string GetPrice(float price, int square)
        {
            if (price * square == 3600)
            {
                Console.WriteLine($"The maximum will be {square.GetType()}");
            }

            if (primaryschoolnear)
            {
                Console.WriteLine($"The full price will be {price.ToString()");
            }
            return price.ToString();
        }
    }
}
