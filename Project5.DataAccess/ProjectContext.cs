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
        public DbSet<Product> Products { get; set; } // relationship
        // override
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Rules
            //optionsBuilder.UseSqlServer(@"Server=localdb\MSSQLLocalDB;");
            //optionsBuilder.UseSqlServer(@"Server=localdb\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
