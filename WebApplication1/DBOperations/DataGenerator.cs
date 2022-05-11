using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
////using WebApplication1.DBOperations.Data

namespace WebApplication1.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider) 
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))    
            {
                //if (context.Books.Any()) 
               // {
               //     return;
                //}
                context.Books.AddRange(
                      new Book
                      {

                          Id = 1,
                          Title = "Lean Startup",
                          GenreId = 1, // Personel Growth
                          PageCount = 200,
                          PublishDate = new DateTime(2022, 05, 12)

                      },
                      new Book
                      {

                          Id = 2,
                          Title = "Herland",
                          GenreId = 2, // Science Fiction
                              PageCount = 250,
                          PublishDate = new DateTime(2021, 04, 11)

                      },
                      new Book
                      {

                          Id = 3,
                          Title = "Dune",
                          GenreId = 1, // Science Fiction
                              PageCount = 550,
                          PublishDate = new DateTime(2020, 03, 10)

                      },
                      new Book
                      {
                          Id = 4,
                          Title = "David Burns",
                          GenreId = 1, //Personel Growth
                              PageCount = 400,
                          PublishDate = new DateTime(2019, 02, 09),
      }
               );

                //context.SaveChanges();
            }
        }
    }
}
