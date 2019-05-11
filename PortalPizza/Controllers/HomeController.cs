using PortalPizza.DAL;
using PortalPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalPizza.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DBContext context = new DBContext();

            /*
            Dodanie do bazy pizzy i składników
            var kategorie = new List<Kategoria>
            {
                new Kategoria(){KategoriaId=1,Nazwa="Włoska"},
                new Kategoria(){KategoriaId=2,Nazwa="Polska"},
                new Kategoria(){KategoriaId=3,Nazwa="Wegańska "},
                new Kategoria(){KategoriaId=4,Nazwa="Amerykańska"},
               
            };
            kategorie.ForEach(k => context.Kategoria.Add(k));
            context.SaveChanges();
            var pizzy = new List<Pizza>
            {
                new Pizza(){PizzaId=1,Cena=15,Nazwa="Chłop z mazur",Skladniki="Boczek,Ser,Papryka,Kiełbasa",Opis="Pyszna pizza z Polski na bazie starej sprawdzonej receptury",Zdjecie="",KategoriaId=2},
                new Pizza(){PizzaId=2,Cena=20,Nazwa="Chłop z podkarpacia",Skladniki="Szynka,Ser,Papryka,Kiełbasa",Opis="Pyszna pizza z Polski na bazie starej sprawdzonej receptury",Zdjecie="",KategoriaId=2},
                new Pizza(){PizzaId=3,Cena=30,Nazwa="Chłopska",Skladniki="Boczek,Ser,Ogórek,Szynka,Kiełbasa",Opis="Pyszna pizza z Polski na bazie starej sprawdzonej receptury",Zdjecie="",KategoriaId=2},
                new Pizza(){PizzaId=4,Cena=25,Nazwa="Chłop ",Skladniki="Boczek,Ser,Papryka,Kiełbasa",Opis="Pyszna pizza z Polski na bazie starej sprawdzonej receptury",Zdjecie="",KategoriaId=2},

                new Pizza(){PizzaId=5,Cena=25,Nazwa="Vesco ",Skladniki="Ser,Ser pleśniowy,Kiełbasa",Opis="Pyszna pizza z Włoch na bazie starej sprawdzonej receptury",Zdjecie="",KategoriaId=1},
                new Pizza(){PizzaId=6,Cena=22,Nazwa="Italliano ",Skladniki="Ser,Ser pleśniowy,Kiełbasa",Opis="Pyszna pizza z Włoch na bazie starej sprawdzonej receptury",Zdjecie="",KategoriaId=1},
                new Pizza(){PizzaId=7,Cena=23,Nazwa="Roma ",Skladniki="Ser,Ser pleśniowy,Kiełbasa",Opis="Pyszna pizza z Włoch na bazie starej sprawdzonej receptury",Zdjecie="",KategoriaId=1},
                new Pizza(){PizzaId=8,Cena=21,Nazwa="Vesco ",Skladniki="Ser,Ser pleśniowy,Mozzarella",Opis="Pyszna pizza z Włoch na bazie starej sprawdzonej receptury",Zdjecie="",KategoriaId=1},

                new Pizza(){PizzaId=9,Cena=21,Nazwa="Szpinakowa ",Skladniki="Szpinak,Ser",Opis="Pyszna pizza bez mięsa na bazie nowoczesnej sprawdzonej receptury",Zdjecie="",KategoriaId=3},
                new Pizza(){PizzaId=10,Cena=21,Nazwa="GreenPizza ",Skladniki="Ogórek,Szpinak,Ser",Opis="Pyszna pizza bez mięsa na bazie nowoczesnej sprawdzonej receptury",Zdjecie="",KategoriaId=3},
                new Pizza(){PizzaId=11,Cena=27,Nazwa="Vegan ",Skladniki="Szpinak,Ser",Opis="Pyszna pizza bez mięsa na bazie nowoczesnej sprawdzonej receptury",Zdjecie="",KategoriaId=3},
                new Pizza(){PizzaId=12,Cena=24,Nazwa="Pasieka ",Skladniki="Ogórek,Cebula,Szpinak,Ser",Opis="Pyszna pizza bez mięsa na bazie nowoczesnej sprawdzonej receptury",Zdjecie="",KategoriaId=3},

                new Pizza(){PizzaId=13,Cena=18,Nazwa="Americanos ",Skladniki="Ogórek,Kiełbasa,Szpinak,Ser",Opis="Pyszna pizza z Ameryki na bazie nowoczesnej sprawdzonej receptury",Zdjecie="",KategoriaId=4},
                new Pizza(){PizzaId=14,Cena=29,Nazwa="Pasieka ",Skladniki="Ogórek,Cebula,Kiełbasa,Ser,Pieczarki",Opis="Pyszna pizza z Ameryki na bazie nowoczesnej sprawdzonej receptury",Zdjecie="",KategoriaId=4},
                new Pizza(){PizzaId=15,Cena=27,Nazwa="Pasieka ",Skladniki="Ogórek,Cebula,Papryka,Ser",Opis="Pyszna pizza z Ameryki na bazie nowoczesnej sprawdzonej receptury",Zdjecie="",KategoriaId=4},
                new Pizza(){PizzaId=16,Cena=22,Nazwa="Pasieka ",Skladniki="Ogórek,Papryka,Szpinak,Ser",Opis="Pyszna pizza z Ameryki na bazie nowoczesnej sprawdzonej receptury",Zdjecie="",KategoriaId=4},
            };
            pizzy.ForEach(k => context.Pizza.Add(k));
            context.SaveChanges();
             */

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}