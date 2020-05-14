using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using zadaniaRoznev2;

namespace zadaniaRozneTesty
{
    class LekarzTests
    {
        [Test]
        public void CanAddPacjentToList()
        {
            Lekarz lekarz = new Lekarz("Andrzej", "Ortodonta", 3900f);
            var pacjent = new Pacjent("Marek", "15");
            lekarz.addPacjentToList(pacjent);

            Assert.That(lekarz.pacjents[0], Is.EqualTo(pacjent));

        }

        [Test]
        public void CanMakeChoroba()
        {
            Lekarz lekarz = new Lekarz("Andrzej", "Ortodonta", 3900f);
            var choroba1 = lekarz.MakeChoroba("name", "startDate");
            Assert.That(choroba1, Is.TypeOf<Choroba>());


        }

        [Test]

        public void CanAddChoroba()
        {
            Choroba choroba = new Choroba("name", "startDate");
            Pacjent pacjent = new Pacjent("probe", "20");


            var result = pacjent.addChoroba(choroba);


            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        [TestCase(0, "probe")]
        [TestCase(1, "Leszek")]
        [TestCase(2, "Bożydar")]
        [TestCase(3, "Andrzej")]
        [TestCase(4, "Pan Paweł")]
        public void ReturnPacjentByIndex(int index, string expected)
        {
            Pacjent pacjent = new Pacjent("probe", "20");
            Lekarz lekarz = new Lekarz("Andrzej", "Ortodonta", 3900f);
            Pacjent pacjent1 = new Pacjent("Leszek", "20");
            Pacjent pacjent2 = new Pacjent("Bożydar", "20");
            Pacjent pacjent3 = new Pacjent("Andrzej", "20");
            Pacjent pacjent4 = new Pacjent("Pan Paweł", "20");

            lekarz.addPacjentToList(pacjent);
            lekarz.addPacjentToList(pacjent1);
            lekarz.addPacjentToList(pacjent2);
            lekarz.addPacjentToList(pacjent3);
            lekarz.addPacjentToList(pacjent4);


            var result = lekarz.showPacjentByIndex(index);
            Assert.That(result.Name, Is.EqualTo(expected));

        }

        [Test]

        public void CanAddMedicine()
        {
            Choroba choroba = new Choroba("HIV", "15.05.20");
            var result = choroba.addMedicine("Apap");

            Assert.That(result, Is.EqualTo(true));
        }
        [Test]

        public void CanShowPacjentsList()
        {
            Pacjent pacjent = new Pacjent("probe", "20");
            Lekarz lekarz = new Lekarz("Andrzej", "Ortodonta", 3900f);
            lekarz.addPacjentToList(pacjent);

            var result = lekarz.showPacjents();

            Assert.That(result, Is.EqualTo(lekarz.pacjents[0]));


        }
    }
}
