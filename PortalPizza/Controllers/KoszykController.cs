using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.SharePoint.Client;
using PortalPizza.DAL;
using PortalPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalPizza.Controllers
{
    public class KoszykController : Controller
    {

        DBContext context = new DBContext();

        // GET: Koszyk
        public ActionResult Index()
        {
            
            List<ZamowienieKoszyk> koszyk = (List<ZamowienieKoszyk>)Session["Koszyk"];
            if(koszyk==null)
            {
                koszyk = new List<ZamowienieKoszyk>();
            }
            var currentUserId = User.Identity.GetUserId();
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var currentUser = manager.FindById(User.Identity.GetUserId());
            ViewBag.Imie = currentUser.Imie;
            ViewBag.Nazwisko = currentUser.Nazwisko;
            return View(koszyk);
        }


        public ActionResult DodajDoKoszyka(int id,int wielkosc,string rozmiar)
        {
            if (Session["Koszyk"] != null)
            {
                List<ZamowienieKoszyk> koszyk = (List<ZamowienieKoszyk>)Session["Koszyk"];
                int zamowienieid = 1;
                if (koszyk!=null)
                {
                    zamowienieid = koszyk.OrderByDescending(p => p.ZamowienieId).First().ZamowienieId + 1;
                }
                Pizza pizza = context.Pizza.Find(id);
                if (koszyk.Find(p => p.Pizza.PizzaId == id && p.Wielkosc==wielkosc)!=null)
                {
                    koszyk.Find(p => p.Pizza.PizzaId == id && p.Wielkosc == wielkosc).Ilosc++;
                    if(rozmiar == "mala")
                    {
                        koszyk.Find(p => p.Pizza.PizzaId == id && p.Wielkosc == wielkosc).Suma += (pizza.Cena - 3);
                    }
                    if (rozmiar == "srednia")
                    {
                        koszyk.Find(p => p.Pizza.PizzaId == id && p.Wielkosc == wielkosc).Suma += (pizza.Cena - 2);
                    }
                    if (rozmiar == "duza")
                    {
                        koszyk.Find(p => p.Pizza.PizzaId == id && p.Wielkosc == wielkosc).Suma += pizza.Cena;
                    }

                }
                else
                {
                    if (rozmiar == "mala")
                    {
                        koszyk.Add(new ZamowienieKoszyk() { ZamowienieId= zamowienieid, Pizza = pizza, Ilosc = 1, Wielkosc = wielkosc,CenaPizza= (pizza.Cena - 3),Suma = (pizza.Cena-3),Rozmiar= "mala" });
                    }
                    if (rozmiar == "srednia")
                    {
                        koszyk.Add(new ZamowienieKoszyk() { ZamowienieId = zamowienieid, Pizza = pizza, Ilosc = 1, Wielkosc = wielkosc, CenaPizza = (pizza.Cena - 2), Suma = (pizza.Cena - 2), Rozmiar = "srednia" });
                    }
                    if (rozmiar == "duza")
                    {
                        koszyk.Add(new ZamowienieKoszyk() { ZamowienieId = zamowienieid, Pizza = pizza, Ilosc = 1, Wielkosc = wielkosc, CenaPizza = pizza.Cena , Suma = pizza.Cena, Rozmiar = "duza" });
                    }
                }
                Session["Koszyk"] = koszyk;
            }
            else
            {
                List<ZamowienieKoszyk> koszyk = new List<ZamowienieKoszyk>();
                Pizza pizza = context.Pizza.Find(id);
                if (rozmiar == "mala")
                {
                    koszyk.Add(new ZamowienieKoszyk() { ZamowienieId = 1, Pizza = pizza, Ilosc = 1, Wielkosc = wielkosc, CenaPizza = (pizza.Cena - 3), Suma = (pizza.Cena - 3), Rozmiar = "mala" });
                }
                if (rozmiar == "srednia")
                {
                    koszyk.Add(new ZamowienieKoszyk() { ZamowienieId = 1, Pizza = pizza, Ilosc = 1, Wielkosc = wielkosc, CenaPizza = (pizza.Cena - 2), Suma = (pizza.Cena - 2), Rozmiar = "srednia" });
                }
                if (rozmiar == "duza")
                {
                    koszyk.Add(new ZamowienieKoszyk() { ZamowienieId = 1, Pizza = pizza, Ilosc = 1, Wielkosc = wielkosc, CenaPizza = pizza.Cena , Suma = pizza.Cena, Rozmiar = "duza" });
                }
                Session["Koszyk"] = koszyk;
                
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult UsunZKoszyka(int id)
        {
            List<ZamowienieKoszyk> koszyk = (List<ZamowienieKoszyk>)Session["Koszyk"];

           int iloscPozycji;
           int koszykzamowienia=0;
           int koszykCena = 0;  
           int idzamowienia = koszyk.Find(p => p.ZamowienieId == id ).ZamowienieId;

           if ((koszyk.Find(p => p.ZamowienieId == id).Ilosc - 1) == 0)
           {
                koszyk.Remove(koszyk.Find(p => p.ZamowienieId == id));
                iloscPozycji = 0;
           }
           else
           {
                koszyk.Find(p => p.ZamowienieId == id).Ilosc--;
                koszykzamowienia = (koszyk.Find(p => p.ZamowienieId == id).Suma - koszyk.Find(p => p.ZamowienieId == id).CenaPizza);
                koszyk.Find(p => p.ZamowienieId == id).Suma -= koszyk.Find(p => p.ZamowienieId == id).CenaPizza;
                iloscPozycji = koszyk.Find(p => p.ZamowienieId == id).Ilosc;

                //koszyk.Find(p => p.Pizza.PizzaId == id && p.Wielkosc == wielkosc)
            }

            if (koszyk.Count == 0)
            {
                Session["Koszyk"] = null;
            }
            else
            {
                koszykCena = koszyk.Sum(a => a.CenaPizza * a.Ilosc);
                Session["Koszyk"] = koszyk;
            }
            var wynik = new KoszykUsuwanieJson()
            {
                IloscPozycjiUsuwanej = iloscPozycji,
                IdPozycjiUsuwanej = idzamowienia,
                KoszykZamowienia = koszykzamowienia,
                KoszykCena=koszykCena,
            };
            

            return Json(wynik);
        }

        public int PobierzIloscKoszyka()
        {
            List<ZamowienieKoszyk> koszyk = (List<ZamowienieKoszyk>)Session["Koszyk"];
            if (koszyk == null)
            {
                koszyk = new List<ZamowienieKoszyk>();
            }
            return koszyk.Sum(a => a.CenaPizza * a.Ilosc);
        }

        public ActionResult Koniec()
        {
            var currentUserId = User.Identity.GetUserId();
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var currentUser = manager.FindById(User.Identity.GetUserId());
            ViewBag.Imie = currentUser.Imie;
            ViewBag.Nazwisko = currentUser.Nazwisko;
            ViewBag.Adres = currentUser.Adres;
            ViewBag.Email = currentUser.Email;
            ViewBag.Telefon = currentUser.Telefon;
            ViewBag.Suma = PobierzIloscKoszyka();

            Session["Koszyk"] = null;

            return View();
        }
    }
}