using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using DataAcceses.EntityFramework;


namespace DataAcceses.EntityFramework
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext 

    {
   
        public DbContext() {}

        public DbContext(DbContextOptions options) : base(options)
        {
          
            Database.EnsureCreated();
        }

        public DbSet<News> News { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Contact> Contacts { get; set; }    
        public DbSet<Announcements> Announcements { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OperationClaims> OperationClaims { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-OOU7LQL;Initial Catalog=staj;Integrated Security=True");
            
        }

    }

  
}
