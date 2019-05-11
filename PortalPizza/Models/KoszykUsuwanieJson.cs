using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalPizza.Models
{
    public class KoszykUsuwanieJson
    {
        public int IloscPozycjiUsuwanej { get; set; }
        public int IdPozycjiUsuwanej { get; set; }
        public int KoszykZamowienia { get; set; }
        public int KoszykCena { get; set; }
    }
}