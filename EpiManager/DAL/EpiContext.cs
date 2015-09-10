using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using EpiManager.Models;

namespace EpiManager.DAL
{
    public class EpiContext : DbContext
    {
        public EpiContext()
            : base("EpiContextMSSQL")
        {

        }

        public DbSet<BodyPart> BodyParts { get; set; }
        public DbSet<PriceHeader> PriceHeaders { get; set; }
        public DbSet<PriceLine> PriceLines { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();


            //modelBuilder.Entity<Customer>().HasRequired(x => x.PriceSet).WithOptional().WillCascadeOnDelete(false);
            //modelBuilder.Entity<Appointment>().HasOptional(x => x.PriceSet).WithOptionalDependent().WillCascadeOnDelete(false);
            //modelBuilder.Entity<Appointment>().HasOptional(x => x.Customer).WithOptionalDependent().WillCascadeOnDelete(false);
        }
    }
}