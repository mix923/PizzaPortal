using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalPizza.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        public String Nazwa { get; set; }

        public virtual IEnumerable<Pizza> Pizza { get; set; }
    }
}