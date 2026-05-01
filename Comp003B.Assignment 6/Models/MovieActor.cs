namespace Comp003B.Assignment_6.Models
{
    public class MovieActor
    {
        public int Id { get; set; }
        public int MovieId { get; set; }

        public int ActorId { get; set; }
        

        public virtual Actor? Actors { get; set; }
        public virtual Movie? Movie { get; set; }

    }
}
