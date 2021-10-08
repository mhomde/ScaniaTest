using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scania.API;
using Scania.Data;

namespace Scania.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var repository = new TruckRepositorySampleData();
            var sampleData = new SampleData();

            Assert.AreEqual(repository.All().Count, sampleData.GetData().Count);

        }

        [TestMethod]
        public void TestMethod2()
        {
            var repository = new TruckRepositorySampleData();
            var sampleData = new SampleData();

            var newTruck = new Truck()
            {
                FuelTank = 1,
                Engine = "dfjdlfjsdl",
                Power = 2,
                Transmission = "Transmission",
                Payload = 43,
                Id = Guid.NewGuid().ToString(),
                NrTires = 3,
                Weight = 9,
                Wheelbase = 2
            };

            repository.Add(newTruck);

            Assert.AreEqual(newTruck, repository[newTruck.Id]);

        }

        [TestMethod]
        public void TestMethod3()
        {
            var repository = new TruckRepositorySampleData();
            var sampleData = new SampleData();

            var firstItem = repository.All().First();
         
            repository.Delete(firstItem);

            Assert.IsFalse(repository.Contains(firstItem.Id));

        }
    }
}
