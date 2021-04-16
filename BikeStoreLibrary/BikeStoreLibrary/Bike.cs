using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreLibrary
{
    public class Bike
    {
        public string name;
        public string brand;
        double price;
        public int size;

        public Bike(string name, string brand, double price, int size)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.size = size;
        }


    }
}
