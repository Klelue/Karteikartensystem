using System.Collections.Generic;
using Model;

namespace AnsichtsFenster.FensterMethoden
{
    class UebersichtMethoden
    {

        public List<Karte> GetGefundenList(string eingabe, List<Karte> gesamtList)
        {
            List<Karte> gefundenList = new List<Karte>();
            eingabe = eingabe.ToLower();

            foreach (Karte karte in gesamtList)
            {
                string stapelLower = karte.Frage.ToLower();

                if (stapelLower.Contains(eingabe))
                {
                    gefundenList.Add(karte);
                }
            }
            

            return gefundenList;
        }

        public List<Stapel> GetGefundenList(string eingabe, List<Stapel> gesamtList)
        {
            List<Stapel> gefundenList = new List<Stapel>();
            eingabe = eingabe.ToLower();

            foreach (Stapel stapel in gesamtList)
            {
                string stapelNameLower = stapel.Name.ToLower();

                if (stapelNameLower.Contains(eingabe))
                {
                    gefundenList.Add(stapel);
                }
            }


            return gefundenList;
        }

    }
}
