using Microsoft.EntityFrameworkCore;
using PokemonModels;
using System.Collections.Generic;

namespace PokemonDL
{
    public class PokemonDbContext:DbContext //this Db Context is like the reference to the database (responsible to create a connection with db, creates session to run queries and get results
    {
        public PokemonDbContext():base()
        {

        }
        public PokemonDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Pokemon> Pokemons { get; set; } // table 1
        public DbSet<Ability> Abilities { get; set; }

        //only use it if the EF cli yelling with error of No Database Context found
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API
            modelBuilder.Entity<Pokemon>()
                 .Property(p => p.Id)
                 .HasColumnName("Id")
                 .ValueGeneratedOnAdd();

            modelBuilder.Entity<Ability>()
                .Property(a => a.Id)
                .HasColumnName("Id")
                .ValueGeneratedOnAdd();

        }

    }
}
