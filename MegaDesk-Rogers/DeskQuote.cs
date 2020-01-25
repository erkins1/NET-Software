using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Rogers
{
    public class DeskQuote
    {
        public Desk Desk { get; set; }
        public string CustomerName { get; set; }
        public int ShippingDays { get; set; }
        public enum ShippingDay
        {
            a3Days,
            a5Days, 
            a7Days,
            a14Days
        }

        const decimal BASE_PRICE = 200;
        private decimal RateLargeDesk = 1;
        private decimal RatePerDrawer = 50;

        public decimal GetQuotePrice()
        {
            /*
            //Get the Width, Depth, NumDrawers, MaterialType from the desk class

            //Find the size of the desk
            decimal deskSize = Width * Depth;
            //Create QuotePrice and add each of the price adjustments
            decimal QuotePrice = BasePrice;
            //Add the price adjustment for the surface area
            if (deskSize > 1000)
            {
                QuotePrice += (deskSize - 1000) * RateLargeDesk;
            }
            //Add the price adjustment for the drawers
            QuotePrice += (NumDrawers * RatePerDrawer);
            //Add the price adjustment for the surface material
            switch (MaterialType)
            {
                case "Oak":
                    QuotePrice += 200;
                    break;
                case "Laminate":
                    QuotePrice += 100;
                    break;
                case "Pine":
                    QuotePrice += 50;
                    break;
                case "Rosewood":
                    QuotePrice += 300;
                    break;
                case "Veneer":
                    QuotePrice += 125;
                    break;
            }
            //Add the price adjustment for the Rush Order
            switch (ShippingDays)
            {
                case 3:
                    if (deskSize < 1000)
                        QuotePrice += 60;
                    else if (deskSize < 2000)
                        QuotePrice += 70;
                    else
                        QuotePrice += 80;
                    break;
                case 5:
                    if (deskSize < 1000)
                        QuotePrice += 40;
                    else if (deskSize < 2000)
                        QuotePrice += 50;
                    else
                        QuotePrice += 60;
                    break;
                case 7:
                    if (deskSize < 1000)
                        QuotePrice += 30;
                    else if (deskSize < 2000)
                        QuotePrice += 35;
                    else
                        QuotePrice += 40;
                    break;
            }

            return QuotePrice;
            */
            return 0;
        }



    }
}
