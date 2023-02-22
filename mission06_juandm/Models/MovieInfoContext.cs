using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace mission06_juandm.Models
{
    public class MovieInfoContext : DbContext
    {
        //constructor!!
        public MovieInfoContext(DbContextOptions<MovieInfoContext> options) : base (options)
        {

        }

        //set of data of type app response it will be a list of stuff in the db 
        public DbSet<ApplicationResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category {CategoryID=1, CategoryName = "Science Fiction"},
                new Category {CategoryID=2, CategoryName = "Sports Drama"},
                new Category {CategoryID=3, CategoryName = "Action"},
                new Category {CategoryID=4, CategoryName = "Other"}

                );
            mb.Entity<ApplicationResponse>().HasData(
                // seeding data with 3 movies, i used ratings.pg13 because it is the element of my ratings enum from the dropdown menu
                new ApplicationResponse
                {
                    MovieID = 1,
                    CategoryID = 1,
                    Title = "Avatar",
                    Year = 2009,
                    Director = "James Cameron",
                    Rating = Ratings.PG13,
                    Edited = false,
                },
                new ApplicationResponse
                {
                    MovieID = 2,
                    CategoryID = 2,
                    Title = "Forever Strong",
                    Year = 2008,
                    Director = "Ryan Little",
                    Rating = Ratings.PG13,
                    Edited = false,
                },
                new ApplicationResponse
                {
                    MovieID = 3,
                    CategoryID = 3,
                    Title = "Creed",
                    Year = 2015,
                    Director = "Ryan Coogler",
                    Rating = Ratings.PG13,
                    Edited = false,
                }
                );
        }
    }
}
