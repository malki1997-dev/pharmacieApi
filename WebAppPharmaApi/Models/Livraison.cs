using Projet_PharmaService.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Projet_PharmaService.Models
{
    public class Livraison
    {

        [Key]
        public int Id { get; set; }

        public DateTime dateLivraison { get; set; }


        public Livraison(LivraisonVM uvm)
        {
            this.dateLivraison = DateTime.Now;

        }
    }
}
