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
    [TestFixture]
    public class SaloniContextTest
    {
        private SaloniContext context = new(SetupFixture.dbContext);
        private Saloni saloni;
        private Auto auto1;
        private Auto auto2;

        [SetUp]
        public void Setup()
        {
            saloni = new("Coleto", "coleto st.");

            auto1 = new("BMW", 2, 4, 1112);
            auto2 = new("colajajeep", 100000, 99999, 1112);

            saloni.Cars.Add(auto1);
            saloni.Cars.Add(auto2);

            context.Create(saloni);
        }

        [TearDown]
        public void DropSaloni()
        {
            foreach (Saloni item in SetupFixture.dbContext.Salons.ToList())
            {
                SetupFixture.dbContext.Salons.Remove(item);
            }

            SetupFixture.dbContext.SaveChanges();
        }


        [Test]
        public void Create()
        {
            Saloni testSalon = new("cc", "kotkist");

            int salonsBefore = SetupFixture.dbContext.Salons.Count();

            context.Create(testSalon);

            int salonsAfter = SetupFixture.dbContext.Salons.Count();

            Assert.That(salonsBefore + 1 == salonsAfter, "Create() does not work!");
        }

        [Test]
        public void Read()
        {
            Saloni readSalon = context.Read(saloni.Id);

            Assert.AreEqual(saloni, readSalon, "Read does not return the same object!");
        }

        [Test]
        public void ReadWithNavigationalProperties()
        {
            Saloni readSalon = context.Read(saloni.Id);
            Assert.That(readSalon.Cars.Contains(auto1)
                && readSalon.Cars.Contains(auto2),
                "auto1 and auto2 are not in the Cars list!");
        }

        [Test]
        public void ReadAll()
        {
            List<Saloni> salonite = (List<Saloni>)context.ReadAll();

            Assert.That(salonite.Count != 0, "ReadAll() does not return cars!");
        }

        [Test]
        public void ReadAllWithNavigationalProperties()
        {
            Saloni readSalon = new("colaja", "barona st.");
            Auto auto = new("Ferrari", 12, 14, readSalon.Id);
            SetupFixture.dbContext.Autos.Add(auto);
            SetupFixture.dbContext.Salons.Add(readSalon);
            context.Create(readSalon);

            List<Saloni> salons = (List<Saloni>)context.ReadAll();

            Assert.That(salons.Count != 0
                && context.Read(readSalon.Id).Cars.Count == 1, "ReadAll() does not return cars!");
        }

        [Test]
        public void Update()
        {
            Saloni changedSalon = context.Read(saloni.Id);

            changedSalon.Name = "COLAJASHOP";
            changedSalon.Adress = "peshtersko shose";

            context.Update(changedSalon);

            Assert.AreEqual(changedSalon, saloni, "Update() does not work!");
        }

        [Test]
        public void Delete()
        {
            int salonsBefore = SetupFixture.dbContext.Salons.Count();

            context.Delete(saloni.Id);
            int salonsAfter = SetupFixture.dbContext.Salons.Count();

            Assert.IsTrue(salonsBefore - 1 == salonsAfter, "Delete() does not work!");
        }
    }
}