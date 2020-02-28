using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDesk_Razor.Data;
using MegaDesk_Razor.Models;

namespace MegaDesk_Razor
{
    public class EditModel : PageModel
    {
        private readonly MegaDesk_Razor.Data.MegaDesk_RazorContext _context;

        public EditModel(MegaDesk_Razor.Data.MegaDesk_RazorContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DeskQuote DeskQuote { get; set; }
        [BindProperty]
        public Desk Desk { get; set; }

        public SelectList TypeList;
        public SelectList ShipDays;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Creates the list of material types for the dropdown
            IQueryable<Materials> typeList = from m in _context.Materials select m;
            TypeList = new SelectList(typeList, "ID", "MaterialType");

            //Creates the list of shipping speeds for the dropdown
            IQueryable<ShippingSpeed> shippingList = from s in _context.ShippingSpeed select s;
            ShipDays = new SelectList(shippingList, "ID", "Speed");

            //Grab the stuff...
            DeskQuote = await _context.DeskQuote.FirstOrDefaultAsync(m => m.ID == id);
            Desk = await _context.Desk.FirstOrDefaultAsync(m => m.ID == DeskQuote.Desk);


            if (DeskQuote == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DeskQuote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeskQuoteExists(DeskQuote.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool DeskQuoteExists(int id)
        {
            return _context.DeskQuote.Any(e => e.ID == id);
        }
    }
}
