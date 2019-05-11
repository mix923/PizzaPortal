using PortalPizza.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalPizza.Controllers
{
    public class PizzaController : Controller
    {
        DBContext context = new DBContext();

        // GET: Pizza
        public ActionResult Index()
        {
            return View(context.Pizza);
        }

        public ActionResult IndexByCategory(int id = 0)
        {
            return View("Index",context.Pizza.Where(k => k.Kategoria.KategoriaId == id || id == 0).ToList());
        }

        public ActionResult Detal(int id)
        {
            return View(context.Pizza.Find(id));
        }
    }
}