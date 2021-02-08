

namespace Model
{
    public class Karte
    {
        public long Id { get; set; }
        public string Frage { get; set; }
        public string Antwort { get; set; }
        public long StapelId { get; set; }
        public int Schwierigkeitsgrad { get; set; }

    }
}
