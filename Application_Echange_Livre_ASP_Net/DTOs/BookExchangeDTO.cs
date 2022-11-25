using Application_Echange_Livre_ASP_Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application_Echange_Livre_ASP_Net.DTOs
{
    public class BookExchangeDTO
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Book Book { get; set; }
        public int BookId { get; set; }

        public virtual User OldOwner { get; set; }
        public int OldOwnerId { get; set; }
    }
}