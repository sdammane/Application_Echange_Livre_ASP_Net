using Application_Echange_Livre_ASP_Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application_Echange_Livre_ASP_Net.DTOs
{
    public class AuthorDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}