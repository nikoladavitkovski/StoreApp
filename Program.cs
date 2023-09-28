using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using GadgetApp.Classes;

namespace GadgetApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            Stan stan = new Stan(3900,6,true);
            Stan stan1 = new Stan(3780,4,true);
            Stan stanovi = new Stan(3460,3,false);
            stan.Value(3900,6,true);
            stan1.Value(3780,4,true);
            stanovi.Value(3460,3,false);
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
