using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk_Razor.Models
{
    public class ShippingSpeed
    {
        public int ID { get; set; }
        public String Speed { get; set; }
        public decimal BasePrice { get; set; }
        public decimal Over1000Price { get; set; }
        public decimal Over2000Price { get; set; }
    }
}
