using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laba_CryptoCurrency.Models;

namespace Laba_CryptoCurrency.Data
{
    public class DataManager : DbContext
    {
        public DataManager() : base()
        { }
        public DataManager(DbContextOptions options) : base(options)
        { }
        public DbSet<CryptoCurrency> CryptoCurrencies { get; set; }
    }
}
