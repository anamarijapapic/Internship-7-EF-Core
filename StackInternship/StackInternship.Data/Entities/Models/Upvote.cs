namespace StackInternship.Data.Entities.Models
{
    public class Upvote
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int? ResourceId { get; set; }
        public Resource Resource { get; set; }

        public int? CommentId { get; set; }
        public Comment Comment { get; set; }
    }
}
