using Microsoft.EntityFrameworkCore;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace EntityFrameworkDemo
{
    // creation relationship between product object in program and table in DB.
    public class NorthWindContext : DbContext // DbContext = EF class
    {
        public Microsoft.EntityFrameworkCore.DbSet<Product> Products { get; set; } // relationship
        // override
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Rules
            //optionsBuilder.UseSqlServer(@"Server=localdb\MSSQLLocalDB;");
            //optionsBuilder.UseSqlServer(@"Server=localdb\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }

    /*
    // In class A inherited for class B; If a change/overwriting is desired for the Do() function in class A, virtual class type and override are used.

    public class A 
    {
        public virtual void Do()
        {
            // Codes
            //
            //
            //
        }
    }
    public class B : A // inherit
    {
        public override void Do()
        {

            //
            base.Do();
            //
        }
    }
    */
}