using System.Collections.Generic;

namespace Model
{
    public class Stapel
    {
        public int Id { get; set; } // in long ändern
        public string Name { get; set; }
        public List<Karte> Karten { get; set; }
        public long GelernteZeitInMinuten { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}