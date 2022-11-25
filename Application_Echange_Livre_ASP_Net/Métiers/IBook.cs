using Application_Echange_Livre_ASP_Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Echange_Livre_ASP_Net.Métiers
{
    public interface IBook
    {
        //Récupérer la liste de tous les livres.
        List<Book> GetAllBook();
        //Récuperer le livre en fonction de son Id.
        Book getBookById(int id);
        //Supprimer le livre en fonction de son Id.
        void DeleteBookById(int id);
        //Mise à jour d'un livre.
        void UpdateBook(Book livre);
        //Ajout d'un livre.
        void AddBook(Book livre);
    }
}
