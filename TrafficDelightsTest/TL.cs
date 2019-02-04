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
            Assert.AreEqual("Bentley", camion.Marque);
            Assert.AreEqual(3, camion.NbPlaces);
        }
        [TestMethod]
        public void TestVehiculeHas4Roues()
        {
            Voiture voiture = new Voiture(4);

            Assert.AreEqual(4, voiture.NbRoues);
        }
        [TestMethod]
        public void BusDepartureIsAeroportAndNumeroBusIs10()
        {
            Bus bus = new Bus();
            Assert.AreEqual("Aéroport", bus.Depart);
            Assert.AreEqual(10, bus.NumeroBus);
            Assert.AreEqual(150, bus.NbPlaces);
            Assert.AreEqual("Blanc", bus.Couleur);
            Assert.AreEqual("Mercedes", bus.Marque);
        }
        [TestMethod]
        public void MotoHas2RouesAndIsADucati()
        {
            Moto moto = new Moto();
            Assert.AreEqual(2, moto.NbRoues);
            Assert.AreEqual("Ducati", moto.Marque);
        }

    }
}
