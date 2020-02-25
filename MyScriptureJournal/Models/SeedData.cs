using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyScriptureJournal.Data;

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

                context.Books.AddRange(
                    new Books
                    {
                        ID = 1,
                        Name = "Genesis"
                    },
                    new Books
                    {
                        ID = 2,
                        Name = "Exodus"
                    },
                    new Books
                    {
                        ID = 3,
                        Name = "Leviticus"
                    },
                    new Books
                    {
                        ID = 4,
                        Name = "Numbers"
                    },
                    new Books
                    {
                        ID = 5,
                        Name = "Deuteronomy"
                    },
                    new Books
                    {
                        ID = 6,
                        Name = "Joshua"
                    },
                    new Books
                    {
                        ID = 7,
                        Name = "Judges"
                    },
                    new Books
                    {
                        ID = 8,
                        Name = "Ruth"
                    }


                    //Add a bunch more later

                );
                context.SaveChanges();








            }

        }

    }
}
