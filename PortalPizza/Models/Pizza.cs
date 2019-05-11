using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalPizza.Models
{
    public class Pizza
    {

        public int PizzaId { get; set; }
        public int Cena { get; set; }
        public String Nazwa { get; set; }
        public String Skladniki { get; set; }
        public String Opis { get; set; }
        public String Zdjecie { get; set; }

        
        public int KategoriaId { get; set; }
        public virtual Kategoria Kategoria { get; set; }

        public virtual ICollection<Zamowienie> Zamowienie { get; set; }
    }
}