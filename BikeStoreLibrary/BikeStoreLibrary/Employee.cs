using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreLibrary
{
    public class Employee
    {
        public string name;
        string city;
        string address;
        public string mail;

        public Employee(string name, string city, string address, string mail)
        {
            this.name = name;
            this.city = city;
            this.address = address;
            this.mail = mail;
        }

    }
}
