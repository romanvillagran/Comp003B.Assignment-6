namespace Comp003B.Assignment_6.Models
{
    public class Actors
    {
        public int ActorId { get; set; }
        public string Name { get; set; }

        public required ICollection<MovieActor> MovieActors { get; set; }
    }
}
