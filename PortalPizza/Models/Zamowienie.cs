using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalPizza.Models
{
    public class Zamowienie
    {
        public int ZamowienieId { get; set; }
        public DateTime DataZamowienia { get; set; }
        public int KosztZamowienia { get; set; }

        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}