namespace StackInternship.Data.Entities.Models
{
    public class View
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int ResourceId { get; set; }
        public Resource Resource { get; set; }
    }
}
