﻿using ECommerce_MW.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_MW.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options ): base(options) //PERMITE UNA CONEXION A LA BASE DE DATOS
        {

        }  

        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<State>().HasIndex("Name", "CountryId").IsUnique(); //indices compuestos
            modelBuilder.Entity<City>().HasIndex("Name", "StateId").IsUnique();  //indices compuestos
        }
    }
}
