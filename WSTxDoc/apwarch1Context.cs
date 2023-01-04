using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using WSTxDoc.Models;

namespace WSTxDoc
{
    public partial class apwarch1Context : DbContext
    {
        public apwarch1Context()
        {
        }

        public apwarch1Context(DbContextOptions<apwarch1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AVersione> AVersiones { get; set; } = null!;
        public virtual DbSet<DArchiviazione> DArchiviaziones { get; set; } = null!;
        public virtual DbSet<DUtenti> DUtentis { get; set; } = null!;
        
        public virtual DbSet<VwArchiviazione> VwArchiviaziones { get; set; } = null!;
        public virtual DbSet<VwDArchiviazione> VwDArchiviaziones { get; set; } = null!;
        public virtual DbSet<VwGlobSetup> VwGlobSetups { get; set; } = null!;
        public virtual DbSet<VwTabelleCampi> VwTabelleCampis { get; set; } = null!;
        public virtual DbSet<VwTbconf> VwTbconfs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=apwsrv;Initial Catalog=apwarch1;User Id=sa;Password=Fenice$Alapag$04");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DArchiviazione>(entity =>
            {
                entity.HasKey(e => new { e.Idstudio, e.CodErogante, e.CodDipendente, e.AnnoMese, e.TipoDoc, e.Ufficiale, e.Id });

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Eliminato).HasDefaultValueSql("((0))");

                entity.Property(e => e.Esterno).HasDefaultValueSql("((0))");

                entity.Property(e => e.InviataMail).HasDefaultValueSql("((0))");

                entity.Property(e => e.VisibilitaPortale).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DUtenti>(entity =>
            {
                entity.HasKey(e => new { e.CodErogante, e.Login });

                entity.Property(e => e.Stato).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<VwArchiviazione>(entity =>
            {
                entity.ToView("vw_Archiviazione");
            });

            modelBuilder.Entity<VwDArchiviazione>(entity =>
            {
                entity.ToView("vw_D_Archiviazione");
            });

            modelBuilder.Entity<VwGlobSetup>(entity =>
            {
                entity.ToView("vw_GlobSetup");
            });

            modelBuilder.Entity<VwTabelleCampi>(entity =>
            {
                entity.ToView("vw_Tabelle_Campi");
            });

            modelBuilder.Entity<VwTbconf>(entity =>
            {
                entity.ToView("vw_TBConf");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
