#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CryptoDemo.Models;

namespace CryptoDemo.Data
{
    public class CryptoDemoContext : DbContext
    {
        public CryptoDemoContext (DbContextOptions<CryptoDemoContext> options)
            : base(options)
        {
        }

        public DbSet<CryptoDemo.Models.Coin> Coin { get; set; }
    }
}
