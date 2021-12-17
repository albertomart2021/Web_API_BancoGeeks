using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API_BancoGeeks.Context
{
    public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> opcions) : base(opcions)
        {

        }

        public DbSet<Entities.Fibonacci> Fibonacci { get; set; }


    }
}
