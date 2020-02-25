using System;
using Microsoft.EntityFrameworkCore;
using System;
using CSharpEntityFramwork2Library.Models;

namespace CSharpEntityFramwork2Library {
    public class AppDbContext : DbContext{

        public virtual DbSet<Customer> Customers { get; set; }

        //protected override void OnModelCreating(ModelBuilder model) {
        //    model.Entity<Customer>(e => {
        //        e.ToTable("Customer");
        //        e.HasKey(x => x.Id;
        //        e.Property(x => x.Name).MaxLength(30).IsRequire();
        //        e.Property(x => x.Active)
        //    }
        //}
    }
}
