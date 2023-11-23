using CelilCavus.IsKurApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CelilCavus.IsKurApi.Context
{
    public class IsKurContext:DbContext
    {
        public IsKurContext() : base("name=IsKurContext")
        {
            
        }
        public DbSet<Work> Work { get; set; }
        public DbSet<Boss> Bosses { get; set; }
        public DbSet<Personel> Personels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ConfigWork());
        }
    }
    public class ConfigWork : EntityTypeConfiguration<Work>
    {
        public ConfigWork()
        {
            HasIndex(x => x.Id);
            Property(x => x.Id);
        }
    }
}