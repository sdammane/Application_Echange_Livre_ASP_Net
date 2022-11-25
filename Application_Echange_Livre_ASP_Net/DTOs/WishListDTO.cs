using Application_Echange_Livre_ASP_Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application_Echange_Livre_ASP_Net.DTOs
{
    public class WishListDTO
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int BookId { get; set; }

        public virtual User User { get; set; }

        public virtual Book Book { get; set; }
    }
}