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
    public class AutoContextTest
    {
        private AutoContext context = new(SetupFixture.dbContext);
        private Auto auto;

        [SetUp]
        public void Setup()
        {
            auto = new(1113, "colajajeep", 100000, 99999, 1112);

            context.Create(auto);
        }

        [TearDown]
        public void DropSaloni()
        {
            foreach (Auto item in SetupFixture.dbContext.Autos.ToList())
            {
                SetupFixture.dbContext.Autos.Remove(item);
            }

            SetupFixture.dbContext.SaveChanges();
        }


        [Test]
        public void Create()
        {
            Auto testAuto = new(1111, "BMW", 2, 4, 1112);

            int autossBefore = SetupFixture.dbContext.Autos.Count();

            context.Create(testAuto);

            int autosAfter = SetupFixture.dbContext.Autos.Count();

            Assert.That(autossBefore + 1 == autosAfter, "Create() does not work!");
        }

        [Test]
        public void Read()
        {
            Auto readAuto = context.Read(auto.Id);

            Assert.AreEqual(auto, readAuto, "Read does not return the same object!");
        }

        [Test]
        public void ReadAll()
        {
            List<Auto> autos = (List<Auto>)context.ReadAll();

            Assert.That(autos.Count != 0, "ReadAll() does not return cars!");
        }

        [Test]
        public void Update()
        {
            Auto changedAuto = context.Read(auto.Id);

            changedAuto.Brand = "Audi";
            changedAuto.Hp = 150;

            context.Update(changedAuto);

            Assert.AreEqual(changedAuto, auto, "Update() does not work!");
        }

        [Test]
        public void Delete()
        {
            int autosBefore = SetupFixture.dbContext.Autos.Count();

            context.Delete(auto.Id);
            int autosAfter = SetupFixture.dbContext.Autos.Count();

            Assert.IsTrue(autosBefore - 1 == autosAfter, "Delete() does not work!");
        }
    }
}