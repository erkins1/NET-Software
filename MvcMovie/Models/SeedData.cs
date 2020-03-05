using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;


namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                
                context.Genre.AddRange(
                    new Genre
                    {
                        GenreName = "Comedy"
                    },
                    new Genre
                    {
                        GenreName = "Drama"
                    },
                    new Genre
                    {
                        GenreName = "Romanic Comedy"
                    },
                    new Genre
                    {
                        GenreName = "Documentary"
                    },
                    new Genre
                    {
                        GenreName = "Adventure"
                    }

                );
                context.SaveChanges();

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "G"
                    },

                    new Movie
                    {
                        Title = "The Singles 2nd Ward",
                        ReleaseDate = DateTime.Parse("2007-3-13"),
                        Genre = "Romantic Comedy",
                        Price = 8.99M,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "Mobsters and Mormons",
                        ReleaseDate = DateTime.Parse("2005-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "PG"
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2014-7-3"),
                        Genre = "Documentary",
                        Price = 9.99M,
                        Rating = "NR"
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Drama",
                        Price = 3.99M,
                        Rating = "PG-13"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}