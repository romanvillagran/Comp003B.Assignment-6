namespace Comp003B.Assignment_6.Models
{
    public class MovieActors
    {
        public int Id { get; set; }
        public int MovieId { get; set; }

        public int ActorId { get; set; }
        

        public virtual Actors? Actors { get; set; }
        public virtual Movie? Movie { get; set; }

    }
}
