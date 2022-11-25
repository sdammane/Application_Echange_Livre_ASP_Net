using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application_Echange_Livre_ASP_Net.Models
{
    public class BookDetails
    {
        

        public int PointValue { get; set; }//Attribute entre 1 et 10

        

        public string Collection { get; set; }

        public string Editeur { get; set; }

        public string SubTitle { get; set; }

        public DateTime EditionDate { get; set; }

        public string Description { get; set; }
    }
}