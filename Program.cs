﻿using System;
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
            Nedvizen_Imot nedvizen_Imot = new Nedvizen_Imot("Dame Gruev 77",(float)48000.00,4);
            Stan stan = new Stan(6,true);
            Stan stan1 = new Stan(4,true);
            Stan stanovi = new Stan(3,false);
            Console.WriteLine($"{nedvizen_Imot.Value(true)}");
            stan.Value(6,true);
            stan1.Value(4,true);
            stanovi.Value(3,false);
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
