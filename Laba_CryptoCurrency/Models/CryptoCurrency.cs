using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba_CryptoCurrency.Models
{
    public class CryptoCurrency
    {
        public int Id { get; set; }
        public string CryptoPair { get; set; }
        public string Interval { get; set; }
        public List<double> Prices { get; set; } 
    }
}
