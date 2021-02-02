using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.FensterMethoden
{
    class UebersichtMethoden
    {

        public List<string> GetGefundenList(string eingabe, List<string> gesamtList)
        {
            List<string> gefundenList = new List<string>();
            eingabe = eingabe.ToLower();

            foreach (string stapel in gesamtList)
            {
                string stapelLower = stapel.ToLower();

                if (stapelLower.Contains(eingabe))
                {
                    gefundenList.Add(stapel);
                }
            }

            return gefundenList;
        }

        public List<string> DatenbankAbfrage()
        {
            List<string> abfrageList = new List<string>();
            abfrageList.Add("bubi");
            abfrageList.Add("Stephan");
            abfrageList.Add("bubicon");
            return abfrageList;
        }


    }
}
