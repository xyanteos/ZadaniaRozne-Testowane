using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using zadaniaRoznev2;

namespace zadaniaRozneTesty
{
    class PacjentTests
    {
        [Test]
        public void DodajeChoroby()
        {
            Pacjent pacjent = new Pacjent("proba","20");
            Choroba choroba = new Choroba("nazwa","20.02.2020");
            pacjent.addChoroba(choroba);
            var wartosc = pacjent.chorobas;
            Assert.That(wartosc[0], Is.EqualTo(choroba));
        }
        [Test]
        [TestCase("name")]
        [TestCase("syfilis")]
        [TestCase("gruźlica")]
        [TestCase("Covid")]
        [TestCase("HIV")]

        public void returnChorobaByName(string name)
        {
            Pacjent pacjent = new Pacjent("probe", "20");
            Choroba choroba = new Choroba("name", "20.02.2020");
            Choroba choroba1 = new Choroba("syfilis", "20.02.2020");
            Choroba choroba2 = new Choroba("gruźlica", "20.02.2020");
            Choroba choroba3 = new Choroba("Covid", "20.02.2020");
            Choroba choroba4 = new Choroba("HIV", "20.02.2020");
            pacjent.addChoroba(choroba);
            pacjent.addChoroba(choroba1);
            pacjent.addChoroba(choroba2);
            pacjent.addChoroba(choroba3);
            pacjent.addChoroba(choroba4);

            var result = pacjent.showChorobaByName(name);
            Assert.That(result.Name, Is.EqualTo(name));

        }


        [Test]
        [TestCase(0, "name")]
        [TestCase(1, "syfilis")]
        [TestCase(2, "gruźlica")]
        [TestCase(3, "Covid")]
        [TestCase(4, "HIV")]

        public void ReturnsChorobaByIndex(int index, string expected)
        {
            Pacjent pacjent1 = new Pacjent("probe", "20");
            Choroba chorobaa = new Choroba("name", "20.02.2020");
            Choroba chorobaa1 = new Choroba("syfilis", "20.02.2020");
            Choroba chorobaa2 = new Choroba("gruźlica", "20.02.2020");
            Choroba chorobaa3 = new Choroba("Covid", "20.02.2020");
            Choroba chorobaa4 = new Choroba("HIV", "20.02.2020");
            pacjent1.addChoroba(chorobaa);
            pacjent1.addChoroba(chorobaa1);
            pacjent1.addChoroba(chorobaa2);
            pacjent1.addChoroba(chorobaa3);
            pacjent1.addChoroba(chorobaa4);

            var result = pacjent1.showChorobaByIndex(index);
            Assert.That(result.Name, Is.EqualTo(expected));

        }



    }
}
