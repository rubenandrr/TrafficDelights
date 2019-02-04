using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrafficDelights;

namespace TrafficDelights
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void TestconflictLorenzo()
        {

        }
        [TestMethod]
        public void TestconflictRubenlol()

        {
            
        }
        [TestMethod]
        public void TestCamionHas6Roues()
        {
            Camion camion = new Camion();

            Assert.AreEqual(6, camion.NbRoues);
        }
        [TestMethod]
        public void BusDepartureIsAeroportAndNumeroBusIs10()
        {
            Bus bus = new Bus();
            Assert.AreEqual("Aéroport", bus.Depart);
            Assert.AreEqual(10, bus.NumeroBus);
        }
    }
}
