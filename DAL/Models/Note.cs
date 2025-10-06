namespace DAL.Models
{
    public class Note
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public DateTime? DeadLine { get; set; }

        public DateTime? CompletedAt { get; set; }

        public bool? IsCompleted { get; set; }
    }
}
