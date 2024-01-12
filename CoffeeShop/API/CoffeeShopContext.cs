using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API;

public partial class CoffeeShopContext : DbContext
{
    public CoffeeShopContext()
    {
    }

    public CoffeeShopContext(DbContextOptions<CoffeeShopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Good> Goods { get; set; }

    public virtual DbSet<Klient> Klients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySQL("Server=127.0.0.1;User=root;Database=CoffeeShop");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Good>(entity =>
        {
            entity.HasKey(e => e.GoodId).HasName("PRIMARY");

            entity.ToTable("Good", "CoffeeShop");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Price).HasMaxLength(100);
        });

        modelBuilder.Entity<Klient>(entity =>
        {
            entity.HasKey(e => e.KlientId).HasName("PRIMARY");

            entity.ToTable("Klient", "CoffeeShop");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Patronymic).HasMaxLength(100);
            entity.Property(e => e.Sale).HasMaxLength(100);
            entity.Property(e => e.Surname).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
