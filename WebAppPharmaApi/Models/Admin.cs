using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace Projet_PharmaService.Models
{
    public class Admin:Personne
    {

        [Key]
        public int Id { get; set; }

        public string login { get; set; }

        public string password { get; set; }

        public DateTime DateCreation { get; set; }

        public Admin(AdminVM uvm): base(uvm)
        {
            this.Cin = uvm.Cin;
            this.Adresse = uvm.Adresse; 
            this.Prenom = uvm.Prenom;   
            this.DateNaissance = uvm.DateNaissance; 
            this.Nom=uvm.Nom;   
            this.AdresseEmail = uvm.AdresseEmail;
            this.Telephone = uvm.Telephone; 
            this.login = uvm.login;
            this.password = uvm.password;
            this.DateCreation = DateTime.Now;
        }

    }
}
