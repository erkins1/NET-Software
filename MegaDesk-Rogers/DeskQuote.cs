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

        const decimal BASE_PRICE = 200.00M;
        const decimal RateLargeDesk = 1.00M;
        const decimal RatePerDrawer = 50.00M;

        Dictionary<string, decimal> materialPrices = new Dictionary<string, decimal>()
        {
            {"Oak", 200.00M },
            {"Laminate", 100.00M },
            {"Pine", 50.00M },
            {"Rosewood", 300.00M },
            {"Veneer", 125.00M }
            };

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
                    QuotePrice += materialPrices.Oak;
                    break;
                case "Laminate":
                    QuotePrice += materialPrices.Laminate;
                    break;
                case "Pine":
                    QuotePrice += materialPrices.Pine;
                    break;
                case "Rosewood":
                    QuotePrice += materialPrices.Rosewood;
                    break;
                case "Veneer":
                    QuotePrice += materialPrices.Veneer;
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
