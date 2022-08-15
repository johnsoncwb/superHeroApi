using System;
using Microsoft.EntityFrameworkCore;
using SuperHerosApi.Models;

namespace SuperHerosApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<SuperHero> SuperHeroes { get; set; } = null!;
    }
}

