using System;
using System.Collections.Generic;
using System.Text;

namespace SicilyLinesMobile
{
    class User
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(int id, string nom, string prenom, string email, string password)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Email = email;
            this.Password = password;
        }
    }
}
