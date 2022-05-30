using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        // A method DbSet is created whenever we creat a Database Context
        // public DbSet<type/entityName> NameOfTableToCreateInDatabase {get; set;}
        // this creates a table named "Activities" in the database with column names same as properties of the "Activity" class
        public DbSet<Activity> Activities { get; set; }
    }
}