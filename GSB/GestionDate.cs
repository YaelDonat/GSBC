using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB
{
    public class GestionDate
    {

        public string getDateDuJour() // récupérer la date du jour sous le format Année complète + mois
        {
            DateTime date = DateTime.Now;
            string asString = date.ToString("yyyyMM");
            return asString;
        }
        public string getJour()
        {
            DateTime date = DateTime.Now;
            string asString = date.ToString("dd");
            return asString;
        }

        public string getDateMoisPrecedent()
        {
            DateTime date = DateTime.Now;
            date = date.AddMonths(-1);
            string asString = date.ToString("yyyyMM");
            return asString;
        }

    }
}
