﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace covariance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string regionName = Console.ReadLine();

            Region region;
            if (regionName == "WestBengal")
            {
                region = new WestBengal();
            }
            else if (regionName == "Karnataka")
            {
                region = new Karnataka();
            }
            else
            {
                region = new Region();
            }

            Flower nationalFlower = region.YourNationalFlower();
            string flowerName = nationalFlower.WhatsYourName();

            Console.WriteLine(flowerName);
        }

    }
}

