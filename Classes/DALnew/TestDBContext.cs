namespace TestWinApp.Classes.DALnew
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TestDBContext : DbContext
    {
        public TestDBContext() : base("name=testdbContext")
        {
        }

        public virtual DbSet<TGROUP> TGROUP { get; set; }
        public virtual DbSet<TPROPERTY> TPROPERTY { get; set; }
        public virtual DbSet<TRELATION> TRELATION { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TGROUP>()
                .Property(e => e.ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TGROUP>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TGROUP>()
                .HasMany(e => e.TPROPERTY)
                .WithOptional(e => e.TGROUP)
                .HasForeignKey(e => e.ID_Group);

            modelBuilder.Entity<TGROUP>()
                .HasMany(e => e.TRELATION)
                .WithOptional(e => e.TGROUP)
                .HasForeignKey(e => e.ID_Child);

            modelBuilder.Entity<TGROUP>()
                .HasMany(e => e.TRELATION1)
                .WithOptional(e => e.TGROUP1)
                .HasForeignKey(e => e.ID_Parent);

            modelBuilder.Entity<TPROPERTY>()
                .Property(e => e.ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TPROPERTY>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TPROPERTY>()
                .Property(e => e.Value)
                .IsUnicode(false);

            modelBuilder.Entity<TPROPERTY>()
                .Property(e => e.ID_Group)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TRELATION>()
                .Property(e => e.ID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TRELATION>()
                .Property(e => e.ID_Parent)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TRELATION>()
                .Property(e => e.ID_Child)
                .HasPrecision(18, 0);
        }
    }
}
