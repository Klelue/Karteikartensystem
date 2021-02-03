using System;
using System.Collections.Generic;
using System.Windows.Forms;

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

        public List<Stapel.Stapel> GetGefundenList(string eingabe, List<Stapel.Stapel> gesamtList)
        {
            List<Stapel.Stapel> gefundenList = new List<Stapel.Stapel>();
            eingabe = eingabe.ToLower();

            foreach (Stapel.Stapel stapel in gesamtList)
            {
                string stapelNameLower = stapel.Name.ToLower();

                if (stapelNameLower.Contains(eingabe))
                {
                    gefundenList.Add(stapel);
                }
            }


            return gefundenList;
        }

        public List<string> DatenbankAbfrage()
        {
            List<string> abfrageList = new List<string>
            {
                "bubi",
                "Stephan",
                "bubicon"
            };
            return abfrageList;
        }



    }
}
