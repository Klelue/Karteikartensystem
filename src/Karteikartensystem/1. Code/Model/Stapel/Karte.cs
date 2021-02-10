namespace Model
{
    public class Karte
    {
        public long Id { get; set; }
        public string Frage { get; set; }
        public string Antwort { get; set; }
        public long StapelId { get; set; }
        public int Schwierigkeitsgrad { get; set; }
        public string FalschAntwort1 { get; set; }
        public string FalschAntwort2 { get; set; }
        public string FalschAntwort3 { get; set; }
        public bool ChallengeMode { get; set; }
    }
}
