namespace SicilyLinesMobile
{
    public class Reservation
    {
        public int Id { get; set; }
        public int IdClient { get; set; }
        public string Destination { get; set; }
        public string DateDepart { get; set; }
        public string DateRetour { get; set; }
        public string Statut { get; set; }

        public Reservation() { }
    }
}