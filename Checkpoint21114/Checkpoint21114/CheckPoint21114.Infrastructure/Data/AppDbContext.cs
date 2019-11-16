using CheckPoint21114.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPoint21114.Infrastructure.Data
{
    public class AppDbContext: DbContext
    {
        public DbSet<Chore> Chores { get; set; }
        public DbSet<ChoreType> ChoreTypes { get; set; }
        public DbSet<Assignment> Assignments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Chore>().HasData(
                    new Chore { Id = 1, Title = "Dusting", Description = "Wipe dust off of tables", Deadline = DateTime.Today, },
                    new Chore { Id = 2, Title = "Take out Garbage", Description = " Collect all garbage and take to dump", 
                        Deadline = DateTime.Today, }
                 
                );

            modelBuilder.Entity<ChoreType>().HasData(
                   new ChoreType { Id = 1, Title = "Inside Chore", },
                   new ChoreType { Id = 2, Title = "OutsideChore",  }

               );

            modelBuilder.Entity<Assignment>().HasNoKey();
          


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ExeriseLog.Db");
                 //change source here
        }
    }
}
