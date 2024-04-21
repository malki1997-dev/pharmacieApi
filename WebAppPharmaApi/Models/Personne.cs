
using Microsoft.EntityFrameworkCore;
using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_PharmaService.Models
{
    [NotMapped] 
    [Index(nameof(Cin), IsUnique = true)]
    public class Personne
    {
        protected string Nom { get; set; }
        protected string Prenom { get; set; }
        protected DateTime DateNaissance { get; set; }
        protected string Adresse { get; set; }
       
        protected string AdresseEmail { get; set; }
        protected string Telephone { get; set; }
     
        protected string Cin { get; set; }

        public Personne(PersonneVM uvm)
        {
            this.Nom = uvm.Nom; 
            this.Prenom = uvm.Prenom;
            this.DateNaissance = DateTime.Now;
            this.Adresse = uvm.Adresse;
            this.AdresseEmail = uvm.AdresseEmail;
            this.Telephone = uvm.Telephone;
            this.Cin = uvm.Cin;
        }

    }
}
