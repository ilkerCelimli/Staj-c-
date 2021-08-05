using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using DataAcceses.EntityFramework;


namespace DataAcceses.EntityFramework
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext 

    {
       public DbContext(DbContextOptions options) : base(options)
       {

       }

       public DbContext()
       {

       }

        public DbSet<News> News { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Contact> Contacts { get; set; }    
        public DbSet<Announcements> Announcements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-OOU7LQL;Initial Catalog=staj;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<News>().HasKey(p => p.Id);
            modelBuilder.Entity<Employee>().HasKey(p => p.Id);
            modelBuilder.Entity<Contact>().HasKey(p => p.Id);
            modelBuilder.Entity<Announcements>().HasKey(p => p.Id);
        }
    }

  
}
