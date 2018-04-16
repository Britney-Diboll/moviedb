using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movie_EF.Data;

namespace Movie_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new DataContext();

            // Insert movies

            /*
            var m1 = new Movies
            {
                Title = "The Neverending Story",
                YearReleased = "1984",
                Genre = "Adventure",
                Tagline = "A boy who needs a friend finds a world that needs a hero in a land beyond imagination!",
                Rating = 7.4m
            };
            dbContext.Movies.Add(m1);

            var m2 = new Movies
            {
                Title = "Child's Play",
                YearReleased = "1988",
                Genre = "Horror",
                Tagline = "This doll is killer.",
                Rating = 6.6m
            };
            dbContext.Movies.Add(m2);

            var m3 = new Movies
            {
                Title = "Teeth",
                YearReleased = "2007",
                Genre = "Fantasy",
                Tagline = "Every rose has its thorns.",
                Rating = 5.4m
            };
            dbContext.Movies.Add(m3);

            var m4 = new Movies
            {
                Title = "Star Wars: Episode IV - A New Hope",
                YearReleased = "1977",
                Genre = "Fantasy",
                Tagline = "Somewhere, in space, this could all be happening right now.",
                Rating = 8.6m
            };
            dbContext.Movies.Add(m4);

            var m5 = new Movies
            {
                Title = "The Shinning",
                YearReleased = "1980",
                Genre = "Horror",
                Tagline = "",
                Rating = 8.4m
            };
            dbContext.Movies.Add(m5);

            var m6 = new Movies
            {
                Title = "Psycho",
                YearReleased = "1960",
                Genre = "Horror",
                Tagline = "Exploring the blackness of the subconscious man!",
                Rating = 8.5m
            };
            dbContext.Movies.Add(m6);

            var m7 = new Movies
            {
                Title = "The Royal Tenenbaums",
                YearReleased = "2001",
                Genre = "Comedy",
                Tagline = "Family Isn't A Word... It's A Sentence",
                Rating = 7.6m
            };
            dbContext.Movies.Add(m7);

            var m8 = new Movies
            {
                Title = "The Room",
                YearReleased = "2003",
                Genre = "Drama",
                Tagline = "A film with the passion of Tennessee Williams.",
                Rating = 3.6m
            };
            dbContext.Movies.Add(m8);

            var m9 = new Movies
            {
                Title = "Puff the Magic Dragon",
                YearReleased = "1978",
                Genre = "Animation",
                Tagline = "One of America's Favorite Songs is now an Unforgettable Animated Special!",
                Rating = 7.6m
            };
            dbContext.Movies.Add(m9);

            var m10 = new Movies
            {
                Title = "Deep Blue Sea",
                YearReleased = "1999",
                Genre = "Action",
                Tagline = "How fast can you swim?",
                Rating = 5.8m
            };
            dbContext.Movies.Add(m10);
            */
            dbContext.SaveChanges();

            // Show all horror movies
            var horrorMovie = dbContext.Movies.Where(w => w.Genre == "Horror");

            Console.WriteLine("Here are the movies in the horror genre!");
            foreach (var film in horrorMovie)
            {
                Console.WriteLine(film.Title);
            }

            // Update movie rating to 10 for movies released in 1988
            /*
            var movie1988 = dbContext.Movies.First(f => f.YearReleased == "1988");
            movie1988.YearReleased = "1988";
            movie1988.Rating = 10.0m;
            dbContext.SaveChanges();
            */

            // Delete The Neverending Story
            var delectFilm = dbContext.Movies.First(f => f.Title == "The Neverending Story");
            dbContext.Movies.Remove(delectFilm);
            dbContext.SaveChanges();
        }
    }
}
