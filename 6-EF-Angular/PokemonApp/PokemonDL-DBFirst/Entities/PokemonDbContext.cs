using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PokemonDL_DBFirst.Entities
{
    public partial class PokemonDbContext : DbContext
    {
        public PokemonDbContext()
        {
        }

        public PokemonDbContext(DbContextOptions<PokemonDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ability> Abilities { get; set; }
        public virtual DbSet<Pokemon> Pokemons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("connection string generated here");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ability>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK__Ability__737584F70DD59B5A");

                entity.ToTable("Ability");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Pp).HasColumnName("PP");
            });

            modelBuilder.Entity<Pokemon>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK__Pokemon__737584F7E759166A");

                entity.ToTable("Pokemon");

                entity.HasIndex(e => e.Type, "IX_Pokemon_Type");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
