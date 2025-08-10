using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication2.Home
{
    public partial class MainMainCon : DbContext
    {
        public MainMainCon()
            : base("name=MainMainCon")
        {
        }

        public virtual DbSet<info> infos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<info>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<info>()
                .Property(e => e.Picture)
                .IsUnicode(false);

            modelBuilder.Entity<info>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<info>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<info>()
                .Property(e => e.DescriptionBig)
                .IsUnicode(false);
        }
    }
}
