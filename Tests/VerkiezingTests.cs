using System;
using System.Linq;
using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class VerkiezingTests
    {
        [TestMethod]
        public void Geen2UitslagregelsMetZelfdePartij()
        {
            var verkiezing = new Verkiezing("UnitTestVerkiezing", new DateTime(2021, 01, 15), 150);
            var partij1 = new Partij("p1", "Partij Nummer 1", "Lijsttrekker 1");

            verkiezing.AddUitslagregel(partij1, 0, 0, 1);
            bool tweedeKeer = verkiezing.AddUitslagregel(partij1, 0, 0, 1);

            Assert.IsFalse(tweedeKeer);
        }

        [TestMethod]
        public void TweeVerschillendePartijenMogelijk()
        {
            var verkiezing = new Verkiezing("UnitTestVerkiezing", new DateTime(2021, 01, 15), 150);
            var partij1 = new Partij("p1", "Partij Nummer 1", "Lijsttrekker 1");
            var partij2 = new Partij("p2", "Partij Nummer 2", "Lijsttrekker 2");

            verkiezing.AddUitslagregel(partij1, 0, 0, 1);
            bool tweedePartij = verkiezing.AddUitslagregel(partij2, 0, 0, 1);

            Assert.IsTrue(tweedePartij);
        }

        [TestMethod]
        public void VrijeZetelsNemenAf()
        {
            var verkiezing = new Verkiezing("UnitTestVerkiezing", new DateTime(2021, 01, 15), 150);
            var partij1 = new Partij("p1", "Partij Nummer 1", "Lijsttrekker 1");
            var partij2 = new Partij("p2", "Partij Nummer 2", "Lijsttrekker 2");

            verkiezing.AddUitslagregel(partij1, 0, 0, 1);
            verkiezing.AddUitslagregel(partij2, 0, 0, 10);

            Assert.AreEqual(139, verkiezing.VrijeZetels);
        }

        [TestMethod]
        public void ZetelAantal75NietGenoeg()
        {
            var verkiezing = new Verkiezing("UnitTestVerkiezing", new DateTime(2021, 01, 15), 150);
            var partij1 = new Partij("p1", "Partij Nummer 1", "Lijsttrekker 1");
            var uitslag = new Uitslagregel(partij1, 0, 0, 75);
            verkiezing.SelecteerRegel(uitslag);

            Assert.IsFalse(verkiezing.MinimaleAantalZetelsBehaald());
        }

        [TestMethod]
        public void ZetelAantal76Genoeg()
        {
            var verkiezing = new Verkiezing("UnitTestVerkiezing", new DateTime(2021, 01, 15), 150);
            var partij1 = new Partij("p1", "Partij Nummer 1", "Lijsttrekker 1");
            var uitslag = new Uitslagregel(partij1, 0, 0, 76);
            verkiezing.SelecteerRegel(uitslag);

            Assert.IsTrue(verkiezing.MinimaleAantalZetelsBehaald());
        }

        [TestMethod]
        public void AantalUitslagregelsToegevoegdGelijkAanAantalInLijst()
        {
            var verkiezing = new Verkiezing("UnitTestVerkiezing", new DateTime(2021, 01, 15), 150);
            var partij1 = new Partij("p1", "Partij Nummer 1", "Lijsttrekker 1");
            var partij2 = new Partij("p2", "Partij Nummer 2", "Lijsttrekker 2");
            var partij3 = new Partij("p3", "Partij Nummer 3", "Lijsttrekker 3");

            verkiezing.AddUitslagregel(partij1, 0, 0, 1);
            verkiezing.AddUitslagregel(partij2, 0, 0, 0);
            verkiezing.AddUitslagregel(partij3, 0, 0, 0);

            Assert.AreEqual(3, verkiezing.GetUitslagregels().Count());
        }

        [TestMethod]
        public void PremierVanGrootstePartij()
        {
            var verkiezing = new Verkiezing("UnitTestVerkiezing", new DateTime(2021, 01, 15), 150);
            var partij1 = new Partij("p1", "Partij Nummer 1", "Lijsttrekker 1");
            var partij2 = new Partij("p2", "Partij Nummer 2", "Lijsttrekker 2");
            verkiezing.SelecteerRegel(new Uitslagregel(partij1, 0, 0, 40));
            verkiezing.SelecteerRegel(new Uitslagregel(partij2, 0, 0, 41));
            verkiezing.MaakCoalitie();
            Assert.AreEqual(verkiezing.GetCoalitie().Premier, "Lijsttrekker 2");
        }

        [TestMethod]
        public void PremierVanGrootstePartij2()
        {
            var verkiezing = new Verkiezing("UnitTestVerkiezing", new DateTime(2021, 01, 15), 150);
            var partij1 = new Partij("p1", "Partij Nummer 1", "Lijsttrekker 1");
            var partij2 = new Partij("p2", "Partij Nummer 2", "Lijsttrekker 2");
            verkiezing.SelecteerRegel(new Uitslagregel(partij1, 0, 0, 41));
            verkiezing.SelecteerRegel(new Uitslagregel(partij2, 0, 0, 40));
            verkiezing.MaakCoalitie();
            Assert.AreEqual(verkiezing.GetCoalitie().Premier, "Lijsttrekker 1");
        }

        [TestMethod]
        public void PremierNietVanNietGrootstePartij()
        {
            var verkiezing = new Verkiezing("UnitTestVerkiezing", new DateTime(2021, 01, 15), 150);
            var partij1 = new Partij("p1", "Partij Nummer 1", "Lijsttrekker 1");
            var partij2 = new Partij("p2", "Partij Nummer 2", "Lijsttrekker 2");
            verkiezing.SelecteerRegel(new Uitslagregel(partij1, 0, 0, 41));
            verkiezing.SelecteerRegel(new Uitslagregel(partij2, 0, 0, 42));
            verkiezing.MaakCoalitie();
            Assert.AreNotEqual(verkiezing.GetCoalitie().Premier, "Lijsttrekker 1");
        }

        [TestMethod]
        public void ZetelsGelijkAanInvoer()
        {
            var partij = new Partij("PVT", "Partij Van Testers", "Test de Tester");
            var uitslag = new Uitslagregel(partij, 0, 0, 2);

            Assert.AreEqual(2, uitslag.Zetels);
        }

        [TestMethod]
        public void WijzigenZetelsMogelijk()
        {
            var partij = new Partij("PVT", "Partij Van Testers", "Test de Tester");
            var uitslag = new Uitslagregel(partij, 0, 0, 2);

            uitslag.Update(0,0,3);

            Assert.AreEqual(3, uitslag.Zetels);
        }
    }
}
