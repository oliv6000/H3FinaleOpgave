using NUnit.Framework;
using BikeStoreLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeStoreLibrary.Tests
{
    [TestFixture()]
    public class StoreTests
    {
        [Test()]
        public void createStoreTest()
        {
            var store = new Store("Lemvig", "Lemvigvej 47");
            store.hireEmployee("Oliver", "Lemvig", "Vandborgvej 17", "oliver@hotmail.com");
            Assert.That(store != null);
        }

        [Test()]
        public void changeStoreAddressTest()
        {
            var store = new Store("Lemvig", "Lemvigvej 47");
            string newAddress = "Lemvigvej 87";
            Assert.That(store.changeAddress(newAddress), Is.True);
        }

        [Test()]
        public void addEmployeeToStoreTest()
        {
            var store = new Store("Lemvig", "Lemvigvej 47");
            Assert.That(store.hireEmployee("Oliver", "Lemvig", "Vandborgvej 17", "oliver@hotmail.com"), Is.True);
        }

        [Test()]
        public void addBikeToStoreTest()
        {
            var store = new Store("Lemvig", "Lemvigvej 47");
            Assert.That(store.addBike("Street racer 27hzb23", "toyota", 3249.95, 22), Is.True);
        }

        [Test()]
        public void getStoreEmployeesTest()
        {
            var store = new Store("Lemvig", "Lemvigvej 47");
            Assert.That(store.hireEmployee("Oliver", "Lemvig", "Vandborgvej 17", "oliver@hotmail.com"), Is.True);
            Employee[] employees = store.getEmployees();

            foreach (var employee in employees)
            {
                Console.WriteLine("Name: " + employee.name + " || Mail: " + employee.mail + " ||");
            }

            Assert.That(employees.Length != 0);
        }

        [Test()]
        public void getStoreBikesTest()
        {
            var store = new Store("Lemvig", "Lemvigvej 47");
            Assert.That(store.addBike("Street racer 27hzb23", "Toyota", 3249.95, 22), Is.True);
            Bike[] bikes = store.getBikes();

            foreach (var bike in bikes)
            {
                Console.WriteLine("Name: " + bike.name + " || Brand: " + bike.brand + " || Size: " + bike.size);
            }

            Assert.That(bikes.Length != 0);
        }

        [Test()]
        public void fireEmployeeTest()
        {
            var store = new Store("Lemvig", "Lemvigvej 47");
            Assert.That(store.hireEmployee("Oliver", "Lemvig", "Vandborgvej 17", "oliver@hotmail.com"), Is.True);

            Employee[] employees = store.getEmployees();
            foreach (var employee in employees)
            {
                if (employee.name == "Oliver" && employee.mail == "oliver@hotmail.com")
                {
                    Assert.That(store.fireEmployee(employee), Is.True);
                }
            }
        }

        [Test()]
        public void terminateBikeTest()
        {
            var store = new Store("Lemvig", "Lemvigvej 47");
            Assert.That(store.addBike("Street racer 27hzb23", "Toyota", 3249.95, 22), Is.True);
            Bike[] bikes = store.getBikes();

            foreach (var bike in bikes)
            {
                if (bike.name == "Street racer 27hzb23" && bike.brand == "Toyota" && bike.size == 22)
                {
                    Assert.That(store.terminateBike(bike), Is.True);
                }
            }
        }


    }
}