﻿using Microsoft.EntityFrameworkCore;
using ExoApi.Models;

namespace ExoApi.Contexts
{
    public class dbExoAPIContext: DbContext
    {
        public dbExoAPIContext()
        {

        }

        public dbExoAPIContext(DbContextOptions<dbExoAPIContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-L8SLKHA\\SQLEXPRESS; initial catalog = dbExoApi; User Id = sa; Password = nfswe ");
            }
        }

        public DbSet<Projeto> Projetos { get; set; }

    }
}
