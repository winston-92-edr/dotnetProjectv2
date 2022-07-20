using dotNetChallange.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace dotNetChallange.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext() : base("DataDbContext")
        {
        }
        public DbSet<DataDbModel> MyData { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataDbModel>().ToTable("MyTable");
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}