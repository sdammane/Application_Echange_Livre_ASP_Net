using Application_Echange_Livre_ASP_Net.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Application_Echange_Livre_ASP_Net.DTOs
{
    public class BookDTO
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [StringLength(13, ErrorMessage = "Invalid ISBN length")]
        public string ISBN { get; set; }

        [Required]
        public double Price { get; set; }

        public BookState BookState { get; set; }

        public virtual ICollection<Categorie> Categories { get; set; }
        public virtual ICollection<Author> Authors { get; set; }

        public string Photo { get; set; }
    }
}