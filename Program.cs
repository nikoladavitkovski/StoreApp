using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics.Eventing.Reader;
using GadgetApp.Classes;

namespace GadgetApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            Stan stan = new Stan((float)5000.00,6,false,200,"Panko Brasnarov");
            Stan stan1 = new Stan((float)4500.00,5,true,200,"Petar Arsov");
            Houses houses = new Houses((float)10000.00, 8, true, 200, "Dame Gruev 77");
            Console.WriteLine(stan.GetPrice());
            Console.WriteLine(stan1.GetPrice());
            Console.WriteLine(houses.GetPrice());
            array.Add("JSON format");
            if (array.Contains("s"))
            {
                Console.WriteLine($"The subarray exists {array[0].GetType()}");
            }
            else
            {
                Console.WriteLine($"This doesn't appear.Value -1");
            }
            Console.ReadLine();
        }
    }
}
