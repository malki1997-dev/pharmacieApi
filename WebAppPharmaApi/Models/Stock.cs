using Projet_PharmaService.statistiques;
using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_PharmaService.Models
{
    public class Stock
    {
        [Key]

        public string StockId { get; set; }
        public int quantite { get; set; }

        public DateTime datePeremption { get; set; }

        public double seuilReaprovisionnement { get; set; }

        public Pharmacie Pharmacie { get; set; }


        public string PharmacieId { get; set; }

        public Medicament Medicament { get; set; }

        public string MedicamentId { get; set; }
        public ICollection<Statistique> statistiques { get; set; }

        public Stock(StockVM uvm)
        {
            this.quantite = uvm.quantite;
            this.datePeremption = DateTime.Now;
            this.seuilReaprovisionnement = uvm.seuilReaprovisionnement;

        }
    }
}
