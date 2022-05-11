using Microsoft.EntityFrameworkCore;

namespace WebApplication1.DBOperations
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        { }
        public DbSet<Book> Books { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("books");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Title).HasColumnName("title");
                entity.Property(e => e.GenreId).HasColumnName("genreıd");
                entity.Property(e => e.PageCount).HasColumnName("pagecount");
                entity.Property(e => e.PublishDate).HasColumnName("publishdate");




            }
            );

        }
    }
}