using System;
using BankingProject.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BankingProject.Data
{
    public partial class banking_dbContext : DbContext
    {
        public banking_dbContext()
        {
        }
        public banking_dbContext(DbContextOptions<banking_dbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<AdminsTable> AdminsTable { get; set; }
        public virtual DbSet<Debit> Debit { get; set; }
        public virtual DbSet<Deposit> Deposit { get; set; }
        public virtual DbSet<Transfer> Transfer { get; set; }
        public virtual DbSet<UserAccount> UserAccount { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=banking_db;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminsTable>(entity =>
            {
                entity.ToTable("Admins_Table");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Debit>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__tmp_ms_x__DDDF6446DF76D4DA");

                entity.ToTable("debit");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.AccountNo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Date).HasMaxLength(50);

                entity.Property(e => e.DebAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Mode).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OldBalance).HasColumnType("numeric(18, 0)");
            });

            modelBuilder.Entity<Deposit>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__tmp_ms_x__DDDF644692C2232E");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.AccountNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Date).HasMaxLength(50);

                entity.Property(e => e.DipAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Mode).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OldBalance).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<Transfer>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PK__Transfer__DDDF6446FFA2A64D");

                entity.Property(e => e.Sno).HasColumnName("sno");

                entity.Property(e => e.AccountNo)
                    .HasColumnName("Account_No")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Date).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ToTransfer).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.HasKey(e => e.AccountNo)
                    .HasName("PK__tmp_ms_x__B19FBF3A78296301");

                entity.ToTable("userAccount");

                entity.Property(e => e.AccountNo)
                    .HasColumnName("Account_No")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Date).HasMaxLength(50);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasMaxLength(50);

                entity.Property(e => e.FatherName)
                    .HasColumnName("Father_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.MaritialStatus)
                    .HasColumnName("maritial_status")
                    .HasMaxLength(50);

                entity.Property(e => e.MotherName)
                    .HasColumnName("Mother_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Oblast).HasMaxLength(50);

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
