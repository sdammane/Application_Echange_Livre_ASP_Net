using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application_Echange_Livre_ASP_Net.Models
{
    public class Abonnement
    {
        public int Id { get; set; }

        public int TotalPoints { get; set; }

        public virtual User IdAbo { get; set; } //Connexion à la clé étrngère.

        public int UserId { get; set; }

        public bool IsAbo { get; set; }

        
    }

   
}