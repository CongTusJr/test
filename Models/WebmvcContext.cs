using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Test.Models;

public partial class WebmvcContext : DbContext
{
    public WebmvcContext()
    {
    }

    public WebmvcContext(DbContextOptions<WebmvcContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=CONGTUS;Database=webmvc;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Idproduct).HasName("PK__product__8D5074247DD151BF");

            entity.ToTable("product");

            entity.Property(e => e.Idproduct).HasColumnName("idproduct");
            entity.Property(e => e.Imageurl)
                .HasMaxLength(300)
                .HasColumnName("imageurl");
            entity.Property(e => e.Introduction)
                .HasMaxLength(300)
                .HasColumnName("introduction");
            entity.Property(e => e.Nameproduct)
                .HasMaxLength(300)
                .HasColumnName("nameproduct");
            entity.Property(e => e.Price)
                .HasColumnType("decimal(10, 0)")
                .HasColumnName("price");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
