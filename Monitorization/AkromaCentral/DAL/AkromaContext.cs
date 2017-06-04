using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using AkromaCentral.Models;

namespace AkromaCentral.DAL
{
    public class AkromaContext:DbContext
    {
        public AkromaContext():base("DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        public DbSet<stmessage> stmessage { get; set; }
        public DbSet<deadman> deadman { get; set; }

    }
}