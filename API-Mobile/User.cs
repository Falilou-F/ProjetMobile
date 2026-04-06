namespace API_Mobile
{
    public class User
    {
        public int Id { get; set; }
        public string Identifiant { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(int id, string identifiant, string nom, string prenom, string email, string password)
        {
            this.Id = id;
            this.Identifiant = identifiant;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Email = email;
            this.Password = password;
        }
        public User() { }
    }
}
