﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Data
{
    public class MyScriptureJournalContext : DbContext
    {
        public MyScriptureJournalContext (DbContextOptions<MyScriptureJournalContext> options)
            : base(options)
        {
        }

        public DbSet<MyScriptureJournal.Models.Scriptures> Scriptures { get; set; }
        public DbSet<MyScriptureJournal.Models.Books> Books { get; set; }
    }
}
