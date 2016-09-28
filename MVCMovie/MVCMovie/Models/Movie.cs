using System;
using System.Data.Entity;   //must bring this in to use entity framework

namespace MVCMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

    }
    //entity framework has a parent class called DbContext which allows us to CRUD foreign key constraints
    //must add connection string for "MovieDbContext" in webConfig file
    public class MovieDbContext : DbContext
    {
        //DbSet us a collection of object "Movie" that we call "Movies"
        public DbSet<Movie> Movies { get; set;}
    }
}