using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaniaRoznev2
{
    public class Przychodnia
    {
        public string Name;
        public List<Lekarz> lekarzs;
        public delegate void giveSalary(string msg);
        public giveSalary a;

        public List<Pacjent> lekkoChorzy = new List<Pacjent>();
        public List<Pacjent> niezleChorzy = new List<Pacjent>();
        public List<Pacjent> tragedia = new List<Pacjent>();




        public Przychodnia(string name)
        {
            Name = name;
            lekarzs = new List<Lekarz>();
        }

        public void giveSalaries(string msg)
        {
            a(msg);
        }


        public Boolean addLekarz(Lekarz lekarz)
        {
            lekarzs.Add(lekarz);
            return true;
        }

        public Boolean addPacjentToLekarz(Pacjent pacjent)
        {
            int temp = 0;
            for (int i = 0; i < lekarzs.Count - 1; i++)
            {
                if ((lekarzs[i] < lekarzs[i + 1]) && (!(lekarzs[i].pacjents.Contains(pacjent))))
                {
                    temp = i;
                }
            }
            if ((temp == 0) && (lekarzs[temp].pacjents.Contains(pacjent)))
            {
                temp++;
            }
            lekarzs[temp].addPacjentToList(pacjent);
            return true;

        }

        public void groupAllPacjenci()
        {

            foreach (Lekarz lekarz in lekarzs)
            {
                foreach (Pacjent pacjent in lekarz.pacjents)
                {
                    if (pacjent.getChorobas().Count < 3)
                    {
                        if (!(lekkoChorzy.Contains(pacjent)))
                        {
                            lekkoChorzy.Add(pacjent);
                        }

                    }
                    else if ((pacjent.getChorobas().Count >= 3) && (pacjent.getChorobas().Count < 6))
                    {
                        if (!(lekkoChorzy.Contains(pacjent)))
                        {
                            niezleChorzy.Add(pacjent);

                        }
                    }
                    else
                    {
                        if (!(lekkoChorzy.Contains(pacjent)))
                        {
                            tragedia.Add(pacjent);

                        }

                    }
                }
            }

            Console.WriteLine("Lekko chorzy:");
            foreach (Pacjent pacjent in lekkoChorzy)
            {
                Console.WriteLine(pacjent.ToString());
            }
            Console.WriteLine("Niezle chorzy:");
            foreach (Pacjent pacjent in niezleChorzy)
            {
                Console.WriteLine(pacjent.ToString());
            }
            Console.WriteLine("Tragedia:");
            foreach (Pacjent pacjent in tragedia)
            {
                Console.WriteLine(pacjent.ToString());
            }

        }

        public Lekarz showLekarzByIndex(int index)
        {
            return lekarzs[index];
        }


        public override string ToString()
        {
            return string.Format("Name- {0}", Name);
        }
    }
}
