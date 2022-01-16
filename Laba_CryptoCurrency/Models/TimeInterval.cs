using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba_CryptoCurrency.Models
{
    public class TimeInterval
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public double Price { get; set; }
    }
}
