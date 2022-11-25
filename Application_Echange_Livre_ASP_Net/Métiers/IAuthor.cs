using Application_Echange_Livre_ASP_Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Echange_Livre_ASP_Net.Métiers
{
    public interface IAuthor
    {
        List<Author> GetAllAuthors();
    }
}
