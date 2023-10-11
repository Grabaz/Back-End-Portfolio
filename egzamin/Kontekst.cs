using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace egzamin
{
    public class Kontekst : DbContext
    {
        public DbSet<Rekord> Rekord { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=./bazy_danych.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Rekord>(entity =>
            {
                entity.HasKey(e => e.Date);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(d => d.Points).IsRequired();
            });
        }
    }
}
