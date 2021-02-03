using System.Collections.Generic;

namespace Stapel
{
    public class Stapel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Karte> Karten { get; set; }
    }
}