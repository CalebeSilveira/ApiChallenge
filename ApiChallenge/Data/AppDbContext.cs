using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiChallenge.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Cartao> Cartao { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cartao>()
                .HasData(
                    new Cartao { Id = 1, Numero = 1234567890 },
                    new Cartao { Id = 2, Numero = 0987654321 },
                    new Cartao { Id = 3, Numero = 1234567899 },
                    new Cartao { Id = 4, Numero = 1123456789 });
            //new Cartao { Id = 1, Numero = 4456897922969999},
            //new Cartao { Id = 2, Numero = 4456897999999999 },
            //new Cartao { Id = 3, Numero = 4456897999999999 },
            //new Cartao { Id = 4, Numero = 4456897998199999 });

        }
    }
}
