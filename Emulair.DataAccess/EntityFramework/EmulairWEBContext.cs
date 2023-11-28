using System;
using System.Collections.Generic;
using EmulairWEB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmulairWEB.Context
{
    public partial class EmulairWEBContext : DbContext
    {
        public EmulairWEBContext()
        {
        }

        public EmulairWEBContext(DbContextOptions<EmulairWEBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Game> Games { get; set; } = null!;
        public virtual DbSet<Highlight> Highlights { get; set; } = null!;
        public virtual DbSet<Review> Reviews { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserStat> UserStats { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);Initial Catalog=EmulairWEB;Integrated Security=true;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>(entity =>
            {
                entity.Property(e => e.GameId)
                    .ValueGeneratedNever()
                    .HasColumnName("GameID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.ReleaseDate).HasColumnType("date");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Highlight>(entity =>
            {
                entity.Property(e => e.HighlightId)
                    .ValueGeneratedNever()
                    .HasColumnName("HighlightID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ImageURL");

                entity.Property(e => e.LinkUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("LinkURL");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.Property(e => e.ReviewId)
                    .ValueGeneratedNever()
                    .HasColumnName("ReviewID");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.Property(e => e.ReviewDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK__Reviews__GameID__3F466844");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Reviews__UserID__403A8C7D");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email, "UQ__Users__A9D105348741D448")
                    .IsUnique();

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationDate).HasColumnType("datetime");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Users__RoleID__3A81B327");
            });

            modelBuilder.Entity<UserStat>(entity =>
            {
                entity.HasKey(e => e.StatId)
                    .HasName("PK__UserStat__3A162D1E08378841");

                entity.Property(e => e.StatId)
                    .ValueGeneratedNever()
                    .HasColumnName("StatID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserStats)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserStats__UserI__44FF419A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
