using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DessingPattern.Models
{
    public partial class cursosonlineContext : DbContext
    {
        public cursosonlineContext()
        {
        }

        public cursosonlineContext(DbContextOptions<cursosonlineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aspnetrole> Aspnetroles { get; set; }
        public virtual DbSet<Aspnetroleclaim> Aspnetroleclaims { get; set; }
        public virtual DbSet<Aspnetuser> Aspnetusers { get; set; }
        public virtual DbSet<Aspnetuserclaim> Aspnetuserclaims { get; set; }
        public virtual DbSet<Aspnetuserlogin> Aspnetuserlogins { get; set; }
        public virtual DbSet<Aspnetuserrole> Aspnetuserroles { get; set; }
        public virtual DbSet<Aspnetusertoken> Aspnetusertokens { get; set; }
        public virtual DbSet<Comentario> Comentarios { get; set; }
        public virtual DbSet<Curso> Cursos { get; set; }
        public virtual DbSet<Cursoinstructor> Cursoinstructors { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }
        public virtual DbSet<Identityuser> Identityusers { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Precio> Precios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=localhost; Uid=root; Password=bernibean55; Database=cursosonline; Port=3306");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aspnetrole>(entity =>
            {
                entity.ToTable("aspnetroles");

                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id).HasMaxLength(85);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(85);
            });

            modelBuilder.Entity<Aspnetroleclaim>(entity =>
            {
                entity.ToTable("aspnetroleclaims");

                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.RoleId)
                    .IsRequired()
                    .HasMaxLength(85);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetroleclaims)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetRoleClaims_AspNetRoles_RoleId");
            });

            modelBuilder.Entity<Aspnetuser>(entity =>
            {
                entity.ToTable("aspnetusers");

                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.AccessFailedCount).HasColumnType("int(11)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NombreCompleto).HasColumnName("nombreCompleto");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Aspnetuserclaim>(entity =>
            {
                entity.ToTable("aspnetuserclaims");

                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(85);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserclaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserClaims_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserlogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey })
                    .HasName("PRIMARY");

                entity.ToTable("aspnetuserlogins");

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(85);

                entity.Property(e => e.ProviderKey).HasMaxLength(85);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(85);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserlogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserLogins_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetuserrole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PRIMARY");

                entity.ToTable("aspnetuserroles");

                entity.HasIndex(e => e.RoleId, "IX_AspNetUserRoles_RoleId");

                entity.Property(e => e.UserId).HasMaxLength(85);

                entity.Property(e => e.RoleId).HasMaxLength(85);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetuserroles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserRoles_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Aspnetusertoken>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name })
                    .HasName("PRIMARY");

                entity.ToTable("aspnetusertokens");

                entity.Property(e => e.UserId).HasMaxLength(85);

                entity.Property(e => e.LoginProvider).HasMaxLength(85);

                entity.Property(e => e.Name).HasMaxLength(85);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Aspnetusertokens)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_AspNetUserTokens_AspNetUsers_UserId");
            });

            modelBuilder.Entity<Comentario>(entity =>
            {
                entity.HasKey(e => e.Idcomentario)
                    .HasName("PRIMARY");

                entity.ToTable("comentario");

                entity.HasIndex(e => e.Idcurso, "cursocomentario_idx");

                entity.Property(e => e.Idcomentario)
                    .HasColumnType("int(11)")
                    .HasColumnName("idcomentario");

                entity.Property(e => e.Alumno).HasMaxLength(150);

                entity.Property(e => e.ComentarioTexto).HasMaxLength(150);

                entity.Property(e => e.Idcurso)
                    .HasColumnType("int(11)")
                    .HasColumnName("idcurso");

                entity.Property(e => e.Puntaje).HasColumnType("int(11)");

                entity.HasOne(d => d.IdcursoNavigation)
                    .WithMany(p => p.Comentarios)
                    .HasForeignKey(d => d.Idcurso)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("cursocomentario");
            });

            modelBuilder.Entity<Curso>(entity =>
            {
                entity.HasKey(e => e.Idcurso)
                    .HasName("PRIMARY");

                entity.ToTable("curso");

                entity.Property(e => e.Idcurso)
                    .HasColumnType("int(11)")
                    .HasColumnName("idcurso");

                entity.Property(e => e.Descripcion).HasMaxLength(45);

                entity.Property(e => e.FotoPortada).HasMaxLength(150);

                entity.Property(e => e.Titulo).HasMaxLength(150);
            });

            modelBuilder.Entity<Cursoinstructor>(entity =>
            {
                entity.HasKey(e => new { e.IdInstructor, e.Idcurso })
                    .HasName("PRIMARY");

                entity.ToTable("cursoinstructor");

                entity.HasIndex(e => e.Idcurso, "fkcurso_idx");

                entity.Property(e => e.IdInstructor)
                    .HasColumnType("int(11)")
                    .HasColumnName("idInstructor");

                entity.Property(e => e.Idcurso)
                    .HasColumnType("int(11)")
                    .HasColumnName("idcurso");

                entity.HasOne(d => d.IdInstructorNavigation)
                    .WithMany(p => p.Cursoinstructors)
                    .HasForeignKey(d => d.IdInstructor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkinstructor");

                entity.HasOne(d => d.IdcursoNavigation)
                    .WithMany(p => p.Cursoinstructors)
                    .HasForeignKey(d => d.Idcurso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkcurso");
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Identityuser>(entity =>
            {
                entity.ToTable("identityuser");

                entity.Property(e => e.Id).HasMaxLength(85);

                entity.Property(e => e.AccessFailedCount).HasColumnType("int(11)");

                entity.Property(e => e.NormalizedEmail).HasMaxLength(85);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(85);
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.HasKey(e => e.IdInstructor)
                    .HasName("PRIMARY");

                entity.ToTable("instructor");

                entity.Property(e => e.IdInstructor)
                    .HasColumnType("int(11)")
                    .HasColumnName("idInstructor");

                entity.Property(e => e.Apellidos).HasMaxLength(100);

                entity.Property(e => e.FotoPerfil)
                    .HasMaxLength(150)
                    .HasColumnName("fotoPerfil");

                entity.Property(e => e.Grado).HasMaxLength(45);

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<Precio>(entity =>
            {
                entity.HasKey(e => e.Idprecio)
                    .HasName("PRIMARY");

                entity.ToTable("precio");

                entity.HasIndex(e => e.Idcurso, "preciocurso_idx");

                entity.Property(e => e.Idprecio)
                    .HasColumnType("int(11)")
                    .HasColumnName("idprecio");

                entity.Property(e => e.Idcurso)
                    .HasColumnType("int(11)")
                    .HasColumnName("idcurso");

                entity.Property(e => e.Precioactual)
                    .HasColumnType("decimal(10,0)")
                    .HasColumnName("precioactual");

                entity.Property(e => e.Promocion)
                    .HasColumnType("decimal(10,0)")
                    .HasColumnName("promocion");

                entity.HasOne(d => d.IdcursoNavigation)
                    .WithMany(p => p.Precios)
                    .HasForeignKey(d => d.Idcurso)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("preciocurso");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
