using Microsoft.EntityFrameworkCore;
using Project5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5.DataAccess
{
    public class ProjectContext : DbContext
    {
        // override
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Rules
            //optionsBuilder.UseSqlServer(@"Server=localdb\MSSQLLocalDB;");
            //optionsBuilder.UseSqlServer(@"Server=localdb\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            optionsBuilder.UseSqlServer("D" +
                "ata Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
        public DbSet<Product> Products { get; set; } // relationship
        public DbSet<Personel> Personels { get; set; } // not relationship with DB, So one more should be virtual method. - onModel
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // fluent mapping
            //base.OnModelCreating(modelBuilder);
            // modelBuilder.HasDefaultSchema("admin");
            modelBuilder.Entity<Personel>().ToTable("Employees","dbo"); // ("Table_Name","Schema") and default="dbo"
            modelBuilder.Entity<Personel>().Property(p => p.PersonelId).HasColumnName("EmployeeID");
            modelBuilder.Entity<Personel>().Property(p => p.PersonelName).HasColumnName("FirstName");
            modelBuilder.Entity<Personel>().Property(p => p.PersonelSurname).HasColumnName("LastName");

        }
    }
}
