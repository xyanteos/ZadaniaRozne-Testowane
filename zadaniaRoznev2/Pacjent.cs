using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaniaRoznev2
{
    public class Pacjent
    {
        public string Name;
        public string Age;
        public List<Choroba> chorobas = new List<Choroba>();


        public Pacjent(string name, string age)
        {
            Name = name;
            Age = age;
        }

        public List<Choroba> getChorobas()
        {
            return this.chorobas;
        }

        public Boolean addChoroba(Choroba choroba)
        {
            chorobas.Add(choroba);
            return true;
        }

        public Choroba showChorobaByIndex(int index)
        {
            return chorobas[index];
        }

        public Choroba showChorobaByName(string name)
        {
            foreach (Choroba choroba in chorobas)
            {
                if (choroba.getName() == name)
                {
                    return choroba;
                }
            }
            return null;
        }



        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", Name, Age);
        }
    }
}
