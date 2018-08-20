using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjetoTI.Mysql
{
    public partial class unaspContext : DbContext
    {
        public unaspContext()
        {
        }

        public unaspContext(DbContextOptions<unaspContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aluno> Aluno { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=localhost;User Id=root;Password=123456;Database=unasp");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>(entity =>
            {
                entity.ToTable("aluno");

                entity.HasIndex(e => e.IdEstado)
                    .HasName("FK_IdEstado_Aluno");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DataMatricula)
                    .HasColumnName("dataMatricula")
                    .HasColumnType("date");

                entity.Property(e => e.Foto)
                    .IsRequired()
                    .HasColumnName("foto")
                    .HasColumnType("blob");

                entity.Property(e => e.IdEstado)
                    .HasColumnName("idEstado")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Idade)
                    .HasColumnName("idade")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(50)");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Aluno)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IdEstado_Aluno");
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.ToTable("estado");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasColumnName("nome")
                    .HasColumnType("varchar(50)");
            });
        }
    }
}
