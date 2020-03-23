using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyScriptureJournal.Data;
using System.Text;
using System.IO;

namespace MyScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyScriptureJournalContext(
                serviceProvider.GetRequiredService<DbContextOptions<MyScriptureJournalContext>>()))
            {
                // Look for any movies.
                if (context.Books.Any())
                {
                    return;   // DB has been seeded
                }

                string[] file = File.ReadLines(@"ListOfScriptures.txt").ToArray();
                int i = 0;
                for (i = 0; i < file.Length; i++) {
                    context.Books.AddRange(
                        new Books
                        {
                            Name = file[i]
                        }
                    );
                }
                context.SaveChanges();


            }

        }

    }
}
