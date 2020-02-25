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
                        booksID = 1,
                        bookName = "Genesis"
                    },
                    new Books
                    {
                        booksID = 2,
                        bookName = "Exodus"
                    },
                    new Books
                    {
                        booksID = 3,
                        bookName = "Leviticus"
                    },
                    new Books
                    {
                        booksID = 4,
                        bookName = "Numbers"
                    },
                    new Books
                    {
                        booksID = 5,
                        bookName = "Deuteronomy"
                    },
                    new Books
                    {
                        booksID = 6,
                        bookName = "Joshua"
                    },
                    new Books
                    {
                        booksID = 7,
                        bookName = "Judges"
                    },
                    new Books
                    {
                        booksID = 8,
                        bookName = "Ruth"
                    }


                    //Add a bunch more later

                );
                context.SaveChanges();








            }

        }

    }
}
