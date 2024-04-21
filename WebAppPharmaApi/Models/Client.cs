using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.Security.Permissions;
namespace Projet_PharmaService.Models
{
    public class Client: Personne
    {
        [Key]
        public int Id { get; set; }
        public string Mutuelle { get; set; }
        public string Etat { get; set; }
        public string Password { get; set; }
        
       
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Panier> Paniers { get; set; }

        public Client(ClientVM uvm) :base(uvm)
        {
            this.Cin = uvm.Cin;
            this.Adresse = uvm.Adresse;
            this.Prenom = uvm.Prenom;
            this.DateNaissance = uvm.DateNaissance;
            this.Nom = uvm.Nom;
            this.AdresseEmail = uvm.AdresseEmail;
            this.Telephone = uvm.Telephone;
            this.Etat = uvm.Etat;
            this.Password = uvm.Password;
            this.Mutuelle = uvm.Mutuelle;
        }
    }
}
