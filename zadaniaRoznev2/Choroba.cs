using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaniaRoznev2
{
    public class Choroba
    {
        public string Name;
        public string StartDate;
        public string EndDate;
        public List<String> Medicines;

        public Choroba(string name, string startDate)
        {
            Name = name;
            StartDate = startDate;
            EndDate = "unknown";
            Medicines = new List<string>();
        }

        public string getName()
        {
            return this.Name;
        }


        public Boolean endChoroba(string endDate)
        {
            EndDate = endDate;
            return true;
        }
        public Boolean addMedicine(string medicineName)
        {
            Medicines.Add(medicineName);
            return true;
        }

        public String showMedincineByIndex(int index)
        {
            return Medicines[index];
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, StartDate: {1}, EndDate: {2}", Name, StartDate, EndDate);
        }
    }
}
