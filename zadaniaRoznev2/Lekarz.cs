using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaniaRoznev2
{
     public class Lekarz
    {
        public string Name;
        public string Specjalization;
        public double Salary;
        public List<Pacjent> pacjents = new List<Pacjent>();

        public Lekarz(string name, string specjalization, double salary)
        {
            Name = name;
            Specjalization = specjalization;
            Salary = salary;
        }
        public void przyjmijPensje(string msg)
        {
            Console.WriteLine(msg + " Otrzymalem pensje : {0} ",  Salary);
        }
        public void wywolajPensje(Przychodnia przychodnia)
        {
            przychodnia.a += przyjmijPensje;
        }

        public Boolean addPacjentToList(Pacjent pacjent)
        {
            pacjents.Add(pacjent);
            return true;
        }

        public Choroba MakeChoroba(string chorobaName, string chorobaStart)
        {
            Choroba choroba = new Choroba(chorobaName, chorobaStart);
            return choroba;
        }

        public Boolean addChoroba(Pacjent pacjent, Choroba choroba)
        {
            pacjent.addChoroba(choroba);
            return true;
        }

        public Boolean addMedicine(Choroba choroba, string medicineName)
        {
            choroba.addMedicine(medicineName);
            return true;
        }

        public Pacjent showPacjentByIndex(int index)
        {
            return pacjents[index];
        }

        public Pacjent showPacjents()
        {
            foreach (Pacjent pacjent in pacjents)
            {
                return pacjent;
            }
            return null;
        }

        public static Boolean operator <(Lekarz lekarz1, Lekarz lekarz2)
        {
            if (lekarz1.pacjents.Count < lekarz2.pacjents.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean operator >(Lekarz lekarz1, Lekarz lekarz2)
        {
            if (lekarz1.pacjents.Count > lekarz2.pacjents.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public override string ToString()
        {
            return string.Format("Name- {0}, Specjalization- {1}", Name, Specjalization);
        }


    }
}
