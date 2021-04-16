using System;
using System.Collections.Generic;

namespace BikeStoreLibrary
{
    public class Store
    {
        string city;
        string address;
        List<Employee> employees;
        List<Bike> bikes;

        public Store(string city, string address)
        {
            this.city = city;
            this.address = address;
            employees = new List<Employee>();
            bikes = new List<Bike>();
        }

        public bool changeAddress(string address)
        {
            this.address = address;
            return true;
        }

        public bool hireEmployee(string name, string city, string address, string mail)
        {
            try
            {
                employees.Add(new Employee(name, city, address, mail));
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public bool addBike(string name, string brand, double price, int size)
        {
            try
            {
                bikes.Add(new Bike(name, brand, price, size));
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public Employee[] getEmployees()
        {
            return this.employees.ToArray();
        }

        public Bike[] getBikes()
        {
            return this.bikes.ToArray();
        }

        public bool fireEmployee(Employee post_employee) 
        {
            try
            {
                employees.RemoveAll(employee => post_employee.name == employee.name && post_employee.mail == employee.mail);
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public bool terminateBike(Bike post_bike)
        {
            try
            {
                bikes.RemoveAll(bike => post_bike.name == bike.name && post_bike.brand == bike.brand && post_bike.size == bike.size);
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }
    }
}