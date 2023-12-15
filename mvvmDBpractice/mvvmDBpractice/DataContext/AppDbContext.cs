using System;
using mvvmDBpractice.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Globalization;
namespace mvvmDBpractice.DataContext
{
    public class AppDbContext : DbContext
    {
        //Path donde se va guardar la base de datos
        string DbPath = string.Empty;

        //Tablas de base de datos
        public DbSet<Form> People { get; set; }

        //Estándar del desarrollo con EFC
        public AppDbContext(string dbPath)
        {
            this.DbPath = dbPath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={DbPath}");
        }
    }
}
