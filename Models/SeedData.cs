using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_6_Joisah_Sarles.Models
{
    public class SeedData
    {
        //Here's the stuff to populate the database.
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            FamazonDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<FamazonDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.books.Any())
            {
                context.books.AddRange(
                // All of the books from the spec that are seeded to the database.
                    new Book
                    {
                        title = "Les Miserables",
                        authorFirst = "Victor",                   
                        authorLast = "Hugo",
                        publisher = "Signet",
                        isbn = "978-0451419439",
                        classification = "Fiction",
                        category = "Classic",
                        pages = 1488,
                        price = 9.95
                    },

                    new Book
                    {
                        title = "Team of Rivals",
                        authorFirst = "Doris",
                        authorMiddle = "Kearns",
                        authorLast = "Goodwin",
                        publisher = "Simon & Schuster",
                        isbn = "978-0743270755",
                        classification = "Non-Fiction",
                        category = "Biography",
                        pages = 944,
                        price = 14.58
                    },

                    new Book
                    {
                        title = "The Snowball",
                        authorFirst = "Alice",
                        authorLast = "Schroeder",
                        publisher = "Bantam",
                        isbn = "978-0553384611",
                        classification = "Non-Fiction",
                        category = "Biography",
                        pages = 832,
                        price = 21.54
                    },

                    new Book
                    {
                        title = "American Ulysses",
                        authorFirst = "Ronald",
                        authorMiddle = "C.",
                        authorLast = "White",
                        publisher = "Random House",
                        isbn = "978-0812981254",
                        classification = "Non-Fiction",
                        category = "Biography",
                        pages = 864,
                        price = 11.61
                    },

                    new Book
                    {
                        title = "Unbroken",
                        authorFirst = "Laura",
                        authorLast = "Hillenbrand",
                        publisher = "Random House",
                        isbn = "978-0812974492",
                        classification = "Non-Fiction",
                        category = "Historical",
                        pages = 528,
                        price = 13.33
                    },

                    new Book
                    {
                        title = "The Great Train Robbery",
                        authorFirst = "Michael",
                        authorLast = "Crichton",
                        publisher = "Vintage",
                        isbn = "978-0804171281",
                        classification = "Fiction",
                        category = "Historical Fiction",
                        pages = 288,
                        price = 15.95
                    },

                    new Book
                    {
                        title = "Deep Work",
                        authorFirst = "Cal",
                        authorLast = "Newport",
                        publisher = "Grand Central Publishing",
                        isbn = "978-1455586691",
                        classification = "Non-Fiction",
                        category = "Self-Help",
                        pages = 304,
                        price = 14.99
                    },

                    new Book
                    {
                        title = "It's Your Ship",
                        authorFirst = "Michael",
                        authorLast = "Abrashoff",
                        publisher = "Grand Central Publishing",
                        isbn = "978-1455523023",
                        classification = "Non-Fiction",
                        category = "Self-Help",
                        pages = 240,
                        price = 21.66
                    },

                    new Book
                    {
                        title = "The Virgin Way",
                        authorFirst = "Richard",
                        authorLast = "Branson",
                        publisher = "Portfolio",
                        isbn = "978-1591847984",
                        classification = "Non-Fiction",
                        category = "Business",
                        pages = 400,
                        price = 29.16
                    },

                    new Book
                    {
                        title = "Sycamore Row",
                        authorFirst = "John",
                        authorLast = "Grisham",
                        publisher = "Bantam",
                        isbn = "978-0553393613",
                        classification = "Fiction",
                        category = "Thrillers",
                        pages = 642,
                        price = 15.03
                    }

                    );

                context.SaveChanges();
            }
        }

    }
}
