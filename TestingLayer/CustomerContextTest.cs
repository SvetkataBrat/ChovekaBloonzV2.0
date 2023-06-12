using BusinessLayer;
using DataLayer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestingLayer
{
    [SetUpFixture]
    public class CustomerContextTest
    {
        private CustomerContext context = new(SetupFixture.dbContext);
        private Customer customer;
        private Auto car1;
        private Auto car2;

        [SetUp]
        public void Setup()
        {
            customer = new("Ivan", "Petkov", "kokti", 30, "08888888888");

            car1 = new ("Mercedes GT63 S", 630, 129000, 1112);
            car2 = new ("Porche 911 TurboS", 100000, 99999, 1112);

            customer.Cars.Add(car1);
            customer.Cars.Add(car2);

            context.Create(customer);
        }

        [TearDown]
        public void DropCustomer()
        {
            foreach (Customer item in SetupFixture.dbContext.Customers.ToList())
            {
                SetupFixture.dbContext.Customers.Remove(item);
            }

            SetupFixture.dbContext.SaveChanges();
        }


        [Test]
        public void Create()
        {
            Customer testCustomer = new("Gosho", "Mirov", "kokti1", 23, "08888888888");

            int customersBefore = SetupFixture.dbContext.Customers.Count();

            context.Create(testCustomer);

            int salonsAfter = SetupFixture.dbContext.Salons.Count();
            //tva ne trqq da e taka mai
            Assert.That(customersBefore + 1 == salonsAfter, "Create() does not work!");
        }

        [Test]
        public void Read()
        {
            Customer readCustomer = context.Read(customer.Id);

            Assert.AreEqual(customer, readCustomer, "Read does not return the same object!");
        }

        [Test]
        public void ReadWithNavigationalProperties()
        {
            Customer readCustomer = context.Read(customer.Id);
            Assert.That(readCustomer.Cars.Contains(car1)
                && readCustomer.Cars.Contains(car2),
                "car1 and car2 are not in the Cars list!");
        }

        [Test]
        public void ReadAll()
        {
            List<Customer> customers = (List<Customer>)context.ReadAll();

            Assert.That(customers.Count != 0, "ReadAll() does not work!");
        }

        [Test]
        public void ReadAllWithNavigationalProperties()
        {
            Customer readCustomer = new ("Ignat", "Baronov", "kokti", 32, "08888888888");
            Auto car = new ("Ferrari", 12, 14, readCustomer.Id);
            SetupFixture.dbContext.Autos.Add(car);
            SetupFixture.dbContext.Customers.Add(readCustomer);
            context.Create(readCustomer);

            List<Saloni> salons = (List<Saloni>)context.ReadAll();

            Assert.That(salons.Count != 0 && context.Read(readCustomer.Id).Cars.Count == 1, "ReadAll() does not return cars!");
        }

        [Test]
        public void Update()
        {
            Customer changedCustomer = context.Read(customer.Id);

            changedCustomer.FirstName = "Coleto";
            changedCustomer.Address = "";

            context.Update(changedCustomer);

            Assert.AreEqual(changedCustomer, customer, "Update() does not work!");
        }

        [Test]
        public void Delete()
        {
            int cusotmersBefore = SetupFixture.dbContext.Customers.Count();

            context.Delete(customer.Id);
            int salonsAfter = SetupFixture.dbContext.Customers.Count();

            Assert.IsTrue(cusotmersBefore - 1 == salonsAfter, "Delete() does not work!");
        }
    }
}
