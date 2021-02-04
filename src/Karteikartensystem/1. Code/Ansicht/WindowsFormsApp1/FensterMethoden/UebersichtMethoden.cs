using System.Collections.Generic;

namespace AnsichtsFenster.FensterMethoden
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

        public List<Model.Stapel> GetGefundenList(string eingabe, List<Model.Stapel> gesamtList)
        {
            List<Model.Stapel> gefundenList = new List<Model.Stapel>();
            eingabe = eingabe.ToLower();

            foreach (Model.Stapel stapel in gesamtList)
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
