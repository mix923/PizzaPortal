using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PortalPizza.Models
{
    public class ZamowienieKoszyk
    {
        public int ZamowienieId { get; set; }
        public Pizza Pizza { get; set; }
        public int CenaPizza { get; set; }
        public int Ilosc { get; set; }
        public int Wielkosc { get; set; }
        public int Suma { get; set; }
        public String Rozmiar { get; set; }
    }
}