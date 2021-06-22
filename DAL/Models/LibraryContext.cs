using Microsoft.EntityFrameworkCore;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DAL.Models
{
    public partial class LibraryContext : DbContext
    {
        public LibraryContext()
        {
        }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Filial> Filial { get; set; }
        public virtual DbSet<Formular> Formular { get; set; }
        public virtual DbSet<Library> Library { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserLibrary> UserLibrary { get; set; }
        public virtual DbSet<UserTypes> UserTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=5CD04958PK;Database=Library;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PublishedYear).HasColumnType("date");

                entity.Property(e => e.Redaction)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Filial>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Formular>(entity =>
            {
                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Formular)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__Formular__IdUser__69C6B1F5");
            });

            modelBuilder.Entity<Library>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFilialNavigation)
                    .WithMany(p => p.Library)
                    .HasForeignKey(d => d.IdFilial)
                    .HasConstraintName("FK__Library__IdFilia__56B3DD81");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.BackDay).HasColumnType("date");

                entity.Property(e => e.TakeDay).HasColumnType("date");

                entity.HasOne(d => d.IdBookNavigation)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.IdBook)
                    .HasConstraintName("FK__Order__IdBook__65F62111");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("FK__Order__IdUser__66EA454A");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Inn).HasColumnName("INN");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.SurName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdDirectorNavigation)
                    .WithMany(p => p.InverseIdDirectorNavigation)
                    .HasForeignKey(d => d.IdDirector)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__User__IdDirector__5D60DB10");

                entity.HasOne(d => d.IdLibraryNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.IdLibrary)
                    .HasConstraintName("FK__User__IdLibrary__5C6CB6D7");

                entity.HasOne(d => d.IdUserTypesNavigation)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.IdUserTypes)
                    .HasConstraintName("FK__User__IdUserType__5B78929E");
            });

            modelBuilder.Entity<UserLibrary>(entity =>
            {
                entity.HasOne(d => d.IdLibraryNavigation)
                    .WithMany(p => p.UserLibrary)
                    .HasForeignKey(d => d.IdLibrary)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__UserLibra__IdLib__61316BF4");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.UserLibrary)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK__UserLibra__IdUse__603D47BB");
            });

            modelBuilder.Entity<UserTypes>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
