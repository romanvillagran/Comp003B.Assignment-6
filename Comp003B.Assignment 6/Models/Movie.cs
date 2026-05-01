namespace Comp003B.Assignment_6.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        public string? Title     { get; set; }

        public int Year { get; set; }

        public ICollection<MovieActor>? MovieActors { get; set; }
    }
}
