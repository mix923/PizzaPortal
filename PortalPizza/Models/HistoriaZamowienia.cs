using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalPizza.Models
{
    public class HistoriaZamowienia
    {
        public int HistoriaZamowieniaId { get; set; }
        public String UserID { get; set; }
        public int Cena { get; set; }
        public string Pizza { get; set; }
        public string Data { get; set; }

    }
}