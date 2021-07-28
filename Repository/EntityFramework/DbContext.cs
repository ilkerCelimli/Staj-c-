using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model.impl;

namespace Repository.EntityFramework
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext

    {


        public DbSet<News> News { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<ContactDal> Contacts { get; set; }
        public DbSet<Announcements> Announcements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("@Server=localhost:5432;Database=Staj;User ID=postgres; password=12345;Integrated Security=false;");
        }
    }

  
}
