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
    public class IndexModel : PageModel
    {
        private readonly MegaDesk_Razor.Data.MegaDesk_RazorContext _context;

        public IndexModel(MegaDesk_Razor.Data.MegaDesk_RazorContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        //[BindProperty(SupportsGet = true)]
        //public string sortOrder { get; set; }

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "name";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            var quotes = from q in _context.DeskQuote select q;

            switch (sortOrder)
            {
                case "name_desc":
                    quotes = quotes.OrderByDescending(s => s.CustomerName);
                    break;
                case "Date":
                    quotes = quotes.OrderBy(s => s.Date);
                    break;
                case "date_desc":
                    quotes = quotes.OrderByDescending(s => s.Date);
                    break;
                case "name":
                    quotes = quotes.OrderBy(s => s.CustomerName);
                    break;
            }

            if (!string.IsNullOrEmpty(searchString))
            {
                quotes = quotes.Where(q => q.CustomerName.Contains(searchString));
            }

            DeskQuote = await quotes.ToListAsync();
        }
    }
}
