using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaniaRoznev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Przychodnia przychodnia1 = new Przychodnia("przychondnia1");

            Lekarz lekarz1 = new Lekarz("lekarz1", "specjalizacja1",2500);
            Lekarz lekarz2 = new Lekarz("lekarz2", "specjalizacja2",3654.23);
            Lekarz lekarz3 = new Lekarz("lekarz3", "specjalizacja3",10512.89);

            lekarz1.wywolajPensje(przychodnia1);
            lekarz2.wywolajPensje(przychodnia1);
            lekarz3.wywolajPensje(przychodnia1);


            Pacjent pacjent1 = new Pacjent("pacjent1", "21");
            Pacjent pacjent2 = new Pacjent("pacjent2", "31");
            Pacjent pacjent3 = new Pacjent("pacjent3", "41");
            Pacjent pacjent4 = new Pacjent("pacjent4", "51");

            przychodnia1.addLekarz(lekarz1);
            przychodnia1.addLekarz(lekarz2);
            przychodnia1.addLekarz(lekarz3);

            lekarz1.addPacjentToList(pacjent1);
            lekarz2.addPacjentToList(pacjent2);
            lekarz2.addPacjentToList(pacjent3);

            przychodnia1.addPacjentToLekarz(pacjent4);
            przychodnia1.addPacjentToLekarz(pacjent4);

            lekarz1.showPacjents().ToString();
            lekarz2.showPacjents().ToString();

            przychodnia1.groupAllPacjenci();
            
            przychodnia1.giveSalaries("Wydano Pensje!");

            Console.ReadKey();



        }
    }
}
