using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk_Razor.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }
        public String CustomerName { get; set; }
        public DateTime Date { get; set; }
        public int Desk { get; set; }               //This is a Foreign Key
        public int ShippingSpeed { get; set; }      //This is a Foreign Key

        const decimal BasePrice = 200.00M;
        const decimal RateLargeDesk = 1.00M;
        const decimal RatePerDrawer = 50.00M;

        public decimal GetQuotePrice()
        {
            return 0;
        }

    }
}
