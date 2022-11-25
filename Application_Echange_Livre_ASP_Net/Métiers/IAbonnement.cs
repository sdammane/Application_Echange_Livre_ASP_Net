using Application_Echange_Livre_ASP_Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Echange_Livre_ASP_Net.Métiers
{
    public interface IAbonnement
    {
        //Obtenir la liste des abonnements 
        List<Abonnement> GetAbonnements();
        //Récupérer les données de l'abonnée en fonction de son id.
        Abonnement GetAbonneById(int id);
        //Supprimer un abonnée en fonction de son Id.
        void DeleteAbonneeById(int id);
        //Ajouter un abonnée
        void AddAbonne(Abonnement abonne);
        //Mise à jour des données de Abonnement.
        void UpdateAbonne(Abonnement abonne);
    }
}
