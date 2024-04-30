using System;
using Microsoft.EntityFrameworkCore;

namespace NetStarter.Basics.DataAccess
{
   public class CollegeDbContext : DbContext
   {
      public DbSet<Course> Courses { get; set; }
         public DbSet<Session> Sessions { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CollegeMonitor.db");
        }

   }
}