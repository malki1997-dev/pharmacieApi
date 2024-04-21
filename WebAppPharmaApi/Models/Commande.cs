using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_PharmaService.Models
{
    public class Commande
    {
        [Key]
        public int CommandeId { get; set; }
        public DateTime DateCommande { get; set; }
        public DateTime HeureCommande { get; set; }
        public string AdresseLivraison { get; set; }
        public string SuiviLivraison { get; set; }
        public IFormFile QR { get; set; }
        public Livreur Livreur{ get; set; }
        [ForeignKey(nameof(Livreur))]
        public int LivreurId { get; set; }
        
        public ICollection<Medicament> Medicament { get; set; }

        public Commande(CommandeVM uvm)
        {
            this.DateCommande = DateTime.Now;
            this.HeureCommande = DateTime.Now;
            this.AdresseLivraison = uvm.AdresseLivraison;
            this.SuiviLivraison = uvm.SuiviLivraison;
           // this.QR = uvm.QR;

        }
    }
}
