using Microsoft.EntityFrameworkCore;
using EmulairWEB.Models;

namespace EmulairWeb.Context
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

        public virtual DbSet<Achievement> Achievements { get; set; } = null!;
        public virtual DbSet<Game> Games { get; set; } = null!;
        public virtual DbSet<Highlight> Highlights { get; set; } = null!;
        public virtual DbSet<Image> Images { get; set; } = null!;
        public virtual DbSet<Review> Reviews { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Stat> Stats { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserAchievement> UserAchievements { get; set; } = null!;
        public virtual DbSet<UserGame> UserGames { get; set; } = null!;
        public virtual DbSet<UserStat> UserStats { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\Local;Initial Catalog=EmulairWEB;Integrated Security=true;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Achievement>(entity =>
            {
                entity.HasKey(e => new { e.AchievementId, e.GameId })
                    .HasName("PK__Achievem__E5C8B99DB9D1D2E5");

                entity.Property(e => e.AchievementId).HasColumnName("AchievementID");

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IconCompletedId).HasColumnName("IconCompletedID");

                entity.Property(e => e.IconPendingId).HasColumnName("IconPendingID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.Achievements)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Achieveme__GameI__3E52440B");

                entity.HasOne(d => d.IconCompleted)
                    .WithMany(p => p.AchievementIconCompleteds)
                    .HasForeignKey(d => d.IconCompletedId)
                    .HasConstraintName("FK__Achieveme__IconC__403A8C7D");

                entity.HasOne(d => d.IconPending)
                    .WithMany(p => p.AchievementIconPendings)
                    .HasForeignKey(d => d.IconPendingId)
                    .HasConstraintName("FK__Achieveme__IconP__3F466844");
            });

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

            modelBuilder.Entity<Image>(entity =>
            {
                entity.Property(e => e.ImageId)
                    .ValueGeneratedNever()
                    .HasColumnName("ImageID");
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
                    .HasConstraintName("FK__Reviews__GameID__300424B4");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Reviews__UserID__30F848ED");
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

            modelBuilder.Entity<Stat>(entity =>
            {
                entity.Property(e => e.StatId)
                    .ValueGeneratedNever()
                    .HasColumnName("StatID");

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.Stats)
                    .HasForeignKey(d => d.GameId)
                    .HasConstraintName("FK__Stats__GameID__37A5467C");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Email, "UQ__Users__A9D1053402BFFE4C")
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
                    .HasConstraintName("FK__Users__RoleID__276EDEB3");
            });

            modelBuilder.Entity<UserAchievement>(entity =>
            {
                entity.HasKey(e => new { e.AchievementId, e.UserId })
                    .HasName("PK__UserAchi__F61BBC2A948F132B");

                entity.Property(e => e.AchievementId).HasColumnName("AchievementID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.Property(e => e.UnlockedAt)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAchievements)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserAchie__UserI__440B1D61");

                entity.HasOne(d => d.Achievement)
                    .WithMany(p => p.UserAchievements)
                    .HasForeignKey(d => new { d.AchievementId, d.GameId })
                    .HasConstraintName("FK__UserAchievements__4316F928");
            });

            modelBuilder.Entity<UserGame>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.GameId })
                    .HasName("PK__UserGame__D52345D1B5FCBEC9");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.GameId).HasColumnName("GameID");

                entity.Property(e => e.LastPlayed).HasColumnType("datetime");

                entity.HasOne(d => d.Game)
                    .WithMany(p => p.UserGames)
                    .HasForeignKey(d => d.GameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserGames__GameI__2D27B809");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserGames)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserGames__UserI__2C3393D0");
            });

            modelBuilder.Entity<UserStat>(entity =>
            {
                entity.HasKey(e => new { e.StatId, e.UserId })
                    .HasName("PK__UserStat__EB6EA1D4539532BA");

                entity.Property(e => e.StatId).HasColumnName("StatID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ValueC)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValueN).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Stat)
                    .WithMany(p => p.UserStats)
                    .HasForeignKey(d => d.StatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserStats__StatI__3A81B327");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserStats)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserStats__UserI__3B75D760");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
