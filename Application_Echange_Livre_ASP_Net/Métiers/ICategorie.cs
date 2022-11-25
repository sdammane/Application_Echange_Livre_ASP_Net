using Application_Echange_Livre_ASP_Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Echange_Livre_ASP_Net.Métiers
{
    public interface ICategorie
    {
        //Récupérer les données de la Catégorie
        List<Categorie> GetAllCategories();
        //Récupérer la catégorie en fonciton de son id.
        Categorie GetCategorieById(int id);
        //Supprimer la catégorie en fonction de son Id.
        void DeleteCategorieById(int id);
        //Ajouter une catégorie.
        void AddCategorie(Categorie categorie);
        //Mise à jour des données de la Catégroie.
        void UpdateCategorie(Categorie categorie);
    }
}
