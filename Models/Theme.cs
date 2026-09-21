namespace Nexora.Api.Models
{
    public class Theme
    {
        public int Id { get; set; }
        public int PhaseId { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }
        public string Description { get; set; }

    }
}
