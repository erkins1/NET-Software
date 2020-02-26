using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MegaDesk_Razor.Models;

namespace MegaDesk_Razor.Data
{
    public class MegaDesk_RazorContext : DbContext
    {
        public MegaDesk_RazorContext (DbContextOptions<MegaDesk_RazorContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDesk_Razor.Models.DeskQuote> DeskQuote { get; set; }
        public DbSet<MegaDesk_Razor.Models.Desk> Desk { get; set; }
        public DbSet<MegaDesk_Razor.Models.Materials> Materials { get; set; }
        public DbSet<MegaDesk_Razor.Models.ShippingSpeed> ShippingSpeed { get; set; }
    }
}
