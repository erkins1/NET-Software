using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDesk_Razor.Data;
using MegaDesk_Razor.Models;

namespace MegaDesk_Razor
{
    public class CreateModel : PageModel
    {
        private readonly MegaDesk_Razor.Data.MegaDesk_RazorContext _context;

        public CreateModel(MegaDesk_Razor.Data.MegaDesk_RazorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            //Creates the list of material types for the dropdown
            IQueryable<Materials> typeList = from m in _context.Materials select m;
            TypeList = new SelectList(typeList, "ID", "MaterialType");

            //Creates the list of shipping speeds for the dropdown
            IQueryable<ShippingSpeed> shippingList = from s in _context.ShippingSpeed select s;
            ShipDays = new SelectList(shippingList, "ID", "Speed");

            return Page();
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }

        [BindProperty]
        public Desk Desk { get; set; }

        public SelectList TypeList;
        public SelectList ShipDays;



        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Desk.Add(Desk);
            await _context.SaveChangesAsync();

            DeskQuote.Desk = Desk.ID;
            DeskQuote.Date = DateTime.Now;
            DeskQuote.QuotePrice = DeskQuote.GetQuotePrice(_context);

            _context.DeskQuote.Add(DeskQuote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
