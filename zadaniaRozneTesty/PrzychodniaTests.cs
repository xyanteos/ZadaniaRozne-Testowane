using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using zadaniaRoznev2;


namespace zadaniaRozneTesty
{
    class PrzychodniaTests
    {

        [Test]
        public void CanAddLekarzToList()
        {
            Lekarz lekarz = new Lekarz("Jan", "Ginekolog", 6900f);
            Przychodnia przychodnia = new Przychodnia("Kaczyńskiego");
            przychodnia.addLekarz(lekarz);


            Assert.That(przychodnia.lekarzs[0], Is.EqualTo(lekarz));
        }

        
        [Test]
        [TestCase(0, "Andrzej")]
        [TestCase(1, "Bartek")]
        [TestCase(2, "Jakub")]
        [TestCase(3, "Maciej")]


        public void ReturnLekarzByIndex(int index, string expected)
        {
            Przychodnia przychodnia1 = new Przychodnia("Kaczyńskiego");
            Lekarz lekarz = new Lekarz("Andrzej", "Ortodonta", 3900f);
            Lekarz lekarz1 = new Lekarz("Bartek", "Ortodonta", 4900f);
            Lekarz lekarz2 = new Lekarz("Jakub", "Ortodonta", 5900f);
            Lekarz lekarz3 = new Lekarz("Maciej", "Ortodonta", 7900f);
            przychodnia1.addLekarz(lekarz);
            przychodnia1.addLekarz(lekarz1);
            przychodnia1.addLekarz(lekarz2);
            przychodnia1.addLekarz(lekarz3);

            var result = przychodnia1.showLekarzByIndex(index);
            Assert.That(result.Name, Is.EqualTo(expected));

        }


        [Test]


        public void CanAddPacjetnToLekarz()
        {
            Lekarz lekarz = new Lekarz("name", "spec", 1234f);
            //Lekarz lekarz1 = new Lekarz("name1", "spec", 1234f);
            //Lekarz lekarz2 = new Lekarz("name2", "spec", 1234f);
            Pacjent pacjent = new Pacjent("name", "age");
            Pacjent pacjent1 = new Pacjent("name1", "age");
            Pacjent pacjent2 = new Pacjent("name2", "age");
            Pacjent pacjent3 = new Pacjent("name3", "age");
            Przychodnia przychodnia2 = new Przychodnia("name");


            przychodnia2.addLekarz(lekarz);
            //przychodnia2.addLekarz(lekarz1);
            //przychodnia2.addLekarz(lekarz2);


            var result = przychodnia2.addPacjentToLekarz(pacjent);
            Assert.That(result, Is.EqualTo(true));

        }


        [Test]
        public void CanAddPacjentToProperLekarz()
        {
            Lekarz lekarz = new Lekarz("name", "spec", 1234f);
            Lekarz lekarz1 = new Lekarz("name1", "spec", 1234f);
            Lekarz lekarz2 = new Lekarz("name2", "spec", 1234f);
            Pacjent pacjent = new Pacjent("name", "age");
            Pacjent pacjent1 = new Pacjent("name1", "age");
            Pacjent pacjent2 = new Pacjent("name2", "age");
            Pacjent pacjent3 = new Pacjent("name3", "age");
            Pacjent pacjent4 = new Pacjent("name4", "age");
            Pacjent pacjent5 = new Pacjent("name5", "age");
            Przychodnia przychodnia2 = new Przychodnia("name");


            przychodnia2.addLekarz(lekarz);
            przychodnia2.addLekarz(lekarz1);
            przychodnia2.addLekarz(lekarz2);
            lekarz.addPacjentToList(pacjent);
            lekarz1.addPacjentToList(pacjent1);
            lekarz1.addPacjentToList(pacjent5);
            lekarz2.addPacjentToList(pacjent2);
            lekarz2.addPacjentToList(pacjent3);


            przychodnia2.addPacjentToLekarz(pacjent4);

            var result = lekarz.pacjents.Count;


            Assert.That(result, Is.EqualTo(2));


        }


        [Test]
        [TestCase(3,1)]
        [TestCase(6,2)]
        [TestCase(1,0)]
        [TestCase(10,2)]
        public void SortPacjentToProperGroup(int number, int expectedInt)
        {



            Przychodnia przychodnia3 = new Przychodnia("name");

            Lekarz lekarz = new Lekarz("name", "spec", 1234f);
            Pacjent pacjent = new Pacjent("name", "age");

            przychodnia3.addLekarz(lekarz);
            lekarz.addPacjentToList(pacjent);



            for (int i = 0; i < number; i++)
            {

                pacjent.addChoroba(new Choroba("name", "20.04.20"));

            }
            przychodnia3.groupAllPacjenci();

            List<List<Pacjent>> listaList = new List<List<Pacjent>>();
            listaList.Add(przychodnia3.lekkoChorzy);
            listaList.Add(przychodnia3.niezleChorzy);
            listaList.Add(przychodnia3.tragedia);
            var wartosc = listaList[expectedInt];
            Assert.That(wartosc.Count, Is.EqualTo(1));


        }


    }
}
