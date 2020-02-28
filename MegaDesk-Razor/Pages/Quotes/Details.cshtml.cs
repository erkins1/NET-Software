using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk_Razor.Data;
using MegaDesk_Razor.Models;

namespace MegaDesk_Razor
{
    public class DetailsModel : PageModel
    {
        private readonly MegaDesk_Razor.Data.MegaDesk_RazorContext _context;

        public DetailsModel(MegaDesk_Razor.Data.MegaDesk_RazorContext context)
        {
            _context = context;
        }

        public DeskQuote DeskQuote { get; set; }
        public Desk Desk { get; set; }
        public Materials Materials { get; set; }
        public ShippingSpeed ShippingSpeed { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DeskQuote = await _context.DeskQuote.FirstOrDefaultAsync(m => m.ID == id);
            Desk = await _context.Desk.FirstOrDefaultAsync(m => m.ID == DeskQuote.Desk);
            Materials = await _context.Materials.FirstOrDefaultAsync(m => m.ID == Desk.Materials);
            ShippingSpeed = await _context.ShippingSpeed.FirstOrDefaultAsync(m => m.ID == DeskQuote.ShippingSpeed);

            if (DeskQuote == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
