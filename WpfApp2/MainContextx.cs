using Microsoft.EntityFrameworkCore;



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class MainContextx : DbContext
    {
        private readonly string _connectionString = "Data Source=192.168.221.12;Initial Catalog=ParserV4;User ID=user02;Password=02;TrustServerCertificate=True";

        public DbSet<Services> services { get; set; }

        public MainContextx()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
