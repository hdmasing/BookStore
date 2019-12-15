using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace BookStore.DatabaseContext
{
    public class BookStoreDatabaseInitializer : DropCreateDatabaseIfModelChanges<BookStoreDbContext>
    {
        protected override void Seed(BookStoreDbContext context)
        {
            context.Books.AddOrUpdate(
                x => x.Name,
                new Book
                {
                    Name = "apple",
                    Price = 1,
                    Description = "Hea raamat",
                    Author = "Jaan Tätte",
                    Year=1998
                    
                },
                new Book
                {
                    Name = "bread",
                    Price = 0.8
                },
                new Book
                {
                    Name = "milk",
                    Price = 1.1
                },
                new Book
                {
                    Name = "chocolate",
                    Price = 2
                },
                new Book
                {
                    Name = "potatoes",
                    Price = 0.6
                }
                );
        }
    }
}