using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;
namespace Projet_PharmaService.Models
{
    public class ArchivePanier
    {
        [Key]
        public int Id { get; set; }

        public DateTime time { get; set; }

        public string motif { get; set; }

        public string statuts { get; set; }

        public double prixTotal { get; set; }

        public int codePromo { get; set; }

        public string livraison { get; set; }

        public string modePaiment { get; set; }

        public Panier panier { get; set; }
        [ForeignKey(nameof(panier))]
        public int PanierId { get; set; }

        public ArchivePanier(ArchivePanierVM uvm)
        {
            this.time = DateTime.Now;
            this.motif = uvm.motif;
            this.statuts = uvm.statuts;
            this.prixTotal = uvm.prixTotal;
            this.livraison = uvm.livraison;
            this.modePaiment = uvm.modePaiment;
        }
    }
}
