using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MobileNic.MVC.Models
{
    public class MobileModels : DbContext
    {
        public MobileModels() : base("Name=DefaultConnection") { }
        
        public DbSet<Departamento> Departamentos { get; set; }

        public DbSet<Municipio> Municipios { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Dispositivo> Dispositivos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }
        
    }
}