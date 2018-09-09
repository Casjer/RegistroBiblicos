using JerryBibles.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

namespace JerryBibles.DAL
{
    public class Contexto : DbContext 
    {
        public DbSet<Libros>libros { get; set; }

        public Contexto() : base ("Constr")
        { }
    }
}
