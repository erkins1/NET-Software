using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection; 
using MegaDesk_Razor.Data;
using System.Text;
using System.IO;

namespace MegaDesk_Razor.Models
{
    //Add the code to populate the Materials and ShippingSpeed tables
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            Console.WriteLine("Does this even run?");
            using (var context = new MegaDesk_RazorContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDesk_RazorContext>>()))
            {
                // Look for any movies.
                if (context.Materials.Any())
                {
                    Console.WriteLine("Database thinks its got something in it.");
                    return;   // DB has been seeded
                }

                context.Materials.AddRange(
                    new Materials
                    {
                        MaterialType = "Oak",
                        Price = 200.00M
                    },
                    new Materials
                    {
                        MaterialType = "Laminate",
                        Price = 100.00M
                    },
                    new Materials
                    {
                        MaterialType = "Pine",
                        Price = 50.00M
                    },
                    new Materials
                    {
                        MaterialType = "Rosewood",
                        Price = 300.00M
                    },
                    new Materials
                    {
                        MaterialType = "Oak",
                        Price = 200.00M
                    },
                    new Materials
                    {
                        MaterialType = "Veneer",
                        Price = 125.00M
                    });

                string[] file = File.ReadLines(@"rushOrderPrices.txt").ToArray();

                context.ShippingSpeed.AddRange(

                    new ShippingSpeed
                    {
                        Speed = "14 Day No Rush",
                        BasePrice = 0.00M,
                        Over1000Price = 0.00M,
                        Over2000Price = 0.00M
                    },

                    new ShippingSpeed
                    {
                        Speed = "3 Day Rush",
                        BasePrice = Convert.ToDecimal(file[0]),
                        Over1000Price = Convert.ToDecimal(file[1]),
                        Over2000Price = Convert.ToDecimal(file[2])
                    },

                    new ShippingSpeed
                    {
                        Speed = "5 Day Rush",
                        BasePrice = Convert.ToDecimal(file[3]),
                        Over1000Price = Convert.ToDecimal(file[4]),
                        Over2000Price = Convert.ToDecimal(file[5])
                    },

                    new ShippingSpeed
                    {
                        Speed = "7 Day Rush",
                        BasePrice = Convert.ToDecimal(file[6]),
                        Over1000Price = Convert.ToDecimal(file[7]),
                        Over2000Price = Convert.ToDecimal(file[8])
                    });
                context.SaveChanges();



























            }
        }
    }
}
