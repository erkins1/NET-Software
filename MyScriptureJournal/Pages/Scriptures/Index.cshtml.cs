using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyScriptureJournal
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        public IList<Scriptures> Scriptures { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]  
        public string ScriptureBook { get; set; }

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            IQueryable<string> bookQuery = from m in _context.Scriptures
                                            orderby m.bookName
                                            select m.bookName;

            var scriptures = from m in _context.Scriptures
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.notes.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(ScriptureBook))
            {
                scriptures = scriptures.Where(x => x.bookName == ScriptureBook);
            }
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());


            Scriptures = await scriptures.ToListAsync();
        }
    }
}
