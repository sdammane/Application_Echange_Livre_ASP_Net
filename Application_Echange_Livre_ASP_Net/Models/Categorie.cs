using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Application_Echange_Livre_ASP_Net.Models
{
    public class Categorie
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20),MinLength(4)]
        public string Name { get; set; }

        public virtual ICollection<Book> Book { get; set; }

        public int BookId { get; set; }
    }
}