using Comp003B.Assignment_6.Models;
using Microsoft.EntityFrameworkCore;

namespace Comp003B.Assignment_6.Data
{
    public class MovieDatabaseContext : DbContext
    {
        public MovieDatabaseContext(DbContextOptions<MovieDatabaseContext> options) : base(options) {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }
    }
}
