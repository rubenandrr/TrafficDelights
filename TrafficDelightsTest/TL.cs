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
<<<<<<< HEAD
        public void TestVehiculeHas4Roues()
        {
            Voiture voiture = new Voiture(4);

            Assert.AreEqual(4, voiture.NbRoues);
=======
        public void BusDepartureIsAeroportAndNumeroBusIs10()
        {
            Bus bus = new Bus();
            Assert.AreEqual("Aéroport", bus.Depart);
            Assert.AreEqual(10, bus.NumeroBus);
>>>>>>> e1593b64a9bc6e67fde476608d6d5c8dfdabe0ad
        }
    }
}
