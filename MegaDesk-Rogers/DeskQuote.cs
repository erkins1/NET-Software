using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MegaDesk_Rogers
{
    public class DeskQuote: Desk
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

        const decimal BasePrice = 200.00M;
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
            
            //Get the Width, Depth, NumDrawers, MaterialType from the form?

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
            switch (MaterialType.ToString())
            {
                case "Oak":
                    QuotePrice += materialPrices["Oak"];
                    break;
                case "Laminate":
                    QuotePrice += materialPrices["Laminate"];
                    break;
                case "Pine":
                    QuotePrice += materialPrices["Pine"];
                    break;
                case "Rosewood":
                    QuotePrice += materialPrices["Rosewood"];
                    break;
                case "Veneer":
                    QuotePrice += materialPrices["Veneer"];
                    break;
            }

            //Add the price adjustment for the Rush Order
            //Build the rushOrder prices array
            string[] file = File.ReadLines(@"rushOrderPrices.txt").ToArray();

            decimal[,] prices = new decimal[3, 3];
            int x = 0;
            int y = 0;
            for (int z = 0; z < file.Length; z++)
            {
                prices[y, x] = Convert.ToDecimal(file[z]);
                x++;
                if (x == 3)
                {
                    x = 0;
                    y++;
                }
            }
            Console.WriteLine(prices.ToString());

            //Choose the correct part of the array
            switch (ShippingDays)
            {
                case 3:
                    x = 0;
                    break;
                case 5:
                    x = 1;
                    break;
                case 7:
                    x = 2;
                    break;
                default:

                    break;
            }
            if (deskSize < 1000)
                y = 0;
            else if (deskSize < 2000)
                y = 1;
            else
                y = 2;

            QuotePrice += prices[y, x];

            return QuotePrice;
            
            //return 0;
        }

    }
}
