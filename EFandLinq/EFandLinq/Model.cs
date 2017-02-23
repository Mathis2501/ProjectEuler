namespace EFandLinq
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=ModelConnectionString")
        {
        }

        public virtual DbSet<PRETTY_HAIR_CUSTOMERS> PRETTY_HAIR_CUSTOMERS { get; set; }
        public virtual DbSet<PRETTY_HAIR_ORDERS> PRETTY_HAIR_ORDERS { get; set; }
        public virtual DbSet<PRETTY_HAIR_PRODUCTS> PRETTY_HAIR_PRODUCTS { get; set; }
        public virtual DbSet<PRETTY_HAIR_ORDERLINE> PRETTY_HAIR_ORDERLINE { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PRETTY_HAIR_CUSTOMERS>()
                .HasMany(e => e.PRETTY_HAIR_ORDERS)
                .WithRequired(e => e.PRETTY_HAIR_CUSTOMERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRETTY_HAIR_ORDERS>()
                .HasMany(e => e.PRETTY_HAIR_ORDERLINE)
                .WithRequired(e => e.PRETTY_HAIR_ORDERS)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PRETTY_HAIR_PRODUCTS>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<PRETTY_HAIR_PRODUCTS>()
                .Property(e => e.ProductDescription)
                .IsUnicode(false);

            modelBuilder.Entity<PRETTY_HAIR_PRODUCTS>()
                .HasMany(e => e.PRETTY_HAIR_ORDERLINE)
                .WithRequired(e => e.PRETTY_HAIR_PRODUCTS)
                .WillCascadeOnDelete(false);
        }
    }
}
