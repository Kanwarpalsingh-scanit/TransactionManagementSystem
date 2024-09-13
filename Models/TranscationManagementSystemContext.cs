using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TransactionManagementSystem.Models;

public partial class TranscationManagementSystemContext : DbContext
{
    public TranscationManagementSystemContext()
    {
    }

    public TranscationManagementSystemContext(DbContextOptions<TranscationManagementSystemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Balance> Balances { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-OFL4DOQA; Database=TranscationManagementSystem; Integrated Security= true; TrustServerCertificate= True;MultipleActiveResultSets=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Balance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Balance__3214EC07A93FD015");

            entity.ToTable("Balance");

            entity.Property(e => e.TotalBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Transact__3214EC0741802D2A");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.RunningBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TransactionType).HasMaxLength(50);
            entity.Property(e => e.TransctionAmount).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
