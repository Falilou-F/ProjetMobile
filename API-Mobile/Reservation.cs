namespace API_Mobile   // ← change juste cette ligne
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

        public Reservation(int id, int idClient, string destination, string dateDepart, string dateRetour, string statut)
        {
            Id = id;
            IdClient = idClient;
            Destination = destination;
            DateDepart = dateDepart;
            DateRetour = dateRetour;
            Statut = statut;
        }
    }
}