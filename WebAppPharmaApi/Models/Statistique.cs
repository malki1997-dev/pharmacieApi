
using Projet_PharmaService.statistiques;
using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projet_PharmaService.Models
{
    public class Statistique
    {
        [Key]
        public int StatistiqueID { get; set; }
        public string period {  get; set; }

        public int nombreVentes { get; set; }

        public double chifreDaffaire { get; set; }

        public double margeBeneficiaire { get; set; }
        [ForeignKey(nameof(StockId))]
        public Stock Stock { get; set; }
       
        public int StockId { get; set; }

        public Statistique(StatistiqueVM uvm)
        {
            this.period = uvm.period;
            this.nombreVentes = uvm.nombreVentes;
            this.chifreDaffaire = uvm.chifreDaffaire;
            this.margeBeneficiaire = uvm.margeBeneficiaire;
            this.Stock = uvm.Stock;
        }
    }
}
