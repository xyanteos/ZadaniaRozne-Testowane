using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using zadaniaRoznev2;

namespace zadaniaRozneTesty
{
    class ChorobaTest
    {
        [Test]
        public void CanAddMedicineToList()
        {
            var choroba = new Choroba("name", "startDate");
            choroba.addMedicine("Ibuprom");
            Assert.That(choroba.Medicines[0], Is.EqualTo("Ibuprom"));
        }
        [Test]
        [TestCase("nazwa1")]
        public void ReturnsName(string nazwa)
        {
            var choroba = new Choroba(nazwa, "start");
            string wyjscie = choroba.getName();
            Assert.That(wyjscie, Is.EqualTo(nazwa));
        }
        [Test]
        [TestCase("21.04.2020")]
        public void UpdatesEndDate(string endDate)
        {
            var choroba = new Choroba("nazwa", "start");
            var result = choroba.endChoroba(endDate);
            Assert.That(result, Is.EqualTo(true));
        }
        [Test]
        [TestCase(0,"Paracetamol")]
        [TestCase(1, "Ibuprom")]
        [TestCase(2, "Apap")]
        public void ProperlyShowsMedicinesByIndex(int index, string expected)
        {
            var choroba = new Choroba("nazwa","startDate");
            choroba.addMedicine("Paracetamol");
            choroba.addMedicine("Ibuprom");
            choroba.addMedicine("Apap");
            var wartosc = choroba.showMedincineByIndex(index);
            Assert.That(wartosc, Is.EqualTo(expected));
        }
    }
}
