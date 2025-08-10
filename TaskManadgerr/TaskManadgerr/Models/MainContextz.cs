using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TaskManadgerr.Models
{
    public partial class MainContextz : DbContext
    {
        public MainContextz()
            : base("name=MainContextz")
        {
        }

        public virtual DbSet<Input> Inputs { get; set; }
        public virtual DbSet<Output> Outputs { get; set; }
        public virtual DbSet<Work_in_progress> Work_in_progresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Input>()
                .Property(e => e.Date)
                .IsUnicode(false);

            modelBuilder.Entity<Input>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Input>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Output>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Output>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Output>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Work_in_progress>()
                .Property(e => e.Date)
                .IsUnicode(false);

            modelBuilder.Entity<Work_in_progress>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Work_in_progress>()
                .Property(e => e.Type)
                .IsUnicode(false);
        }
    }
}
