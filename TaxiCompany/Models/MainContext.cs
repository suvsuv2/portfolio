using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace TaxiCompany.Models
{
    public class MainContext : DbContext
    {
        private readonly string _connectionString = "Data Source=192.168.221.12;initial Catalog=Taxxi07;User ID=user07;Password=07;TrustServerCertificate=True";

        public DbSet<DriverGosling> DriverGoslingZ { get; set;}

        public DbSet<Transport> TransportZ { get; set;}

        public DbSet<OrderZ> ZakazzzZ { get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
          

        }
    }
}
