using Application_Echange_Livre_ASP_Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Echange_Livre_ASP_Net.Métiers
{
    public interface IUser
    {

        //Récupérer la liste des utilisateurs
        List<User> GetUsers();
        //Récupérer l'utilisateur en fonciton de son id
        User getUserById(int id);
        //Supprimer un User en fonction de son id
        void DeletUserById(int id); 
        //Mettre à jour un User
        void UpdateUser(User utilisateur);
        //Insérer un nouveau user
        void AddUser(User utilisateur);
    }
}
