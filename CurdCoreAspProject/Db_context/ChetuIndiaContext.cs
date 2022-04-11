using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CurdCoreAspProject.Db_context
{
    public partial class ChetuIndiaContext : DbContext
    {
        public ChetuIndiaContext()
        {
        }

        public ChetuIndiaContext(DbContextOptions<ChetuIndiaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChetuView> ChetuViews { get; set; }
        public virtual DbSet<EmpChetu> EmpChetus { get; set; }
        public virtual DbSet<LoginEmp> LoginEmps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=CHETUIWK1330\\SQLEXPRESS;Database=ChetuIndia;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChetuView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("chetuView");

                entity.Property(e => e.Eemail)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ename");
            });

            modelBuilder.Entity<EmpChetu>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PK__EmpChetu__D9509F6D33202718");

                entity.ToTable("EmpChetu");

                entity.Property(e => e.Eid).HasColumnName("eid");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Eemail)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("ename");
            });

            modelBuilder.Entity<LoginEmp>(entity =>
            {
                entity.ToTable("LoginEmp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(90)
                    .IsUnicode(false);

                entity.Property(e => e.Ename)
                    .HasMaxLength(70)
                    .IsUnicode(false)
                    .HasColumnName("ename");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("password");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
