using PortalPizza.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PortalPizza.DAL
{
    public class DBContext : DbContext
    {
        public DBContext() : base("DefaultConnection")
        {

        }


        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Kategoria> Kategoria { get; set; }
        public DbSet<HistoriaZamowienia> HistoriaZamowienia { get; set; }

    }
}