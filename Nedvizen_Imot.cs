﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GadgetApp.Classes
{
    abstract class Nedvizen_Imot
    {
        public string address;

        public float price = 2000;

        public int squares = 200;

        public virtual float GetPrice()
        {
            return this.price;
        }

        public Nedvizen_Imot(string address, float price, int squares)
        {
            this.address = address;
            this.price = price;
            this.squares = squares;
        }

        public string Value(bool nearprimaryschool)
        {
            if (nearprimaryschool)
            {
                Console.WriteLine($"The price {price} is 3% higher");
            }
            return address;
        }
    }
}
