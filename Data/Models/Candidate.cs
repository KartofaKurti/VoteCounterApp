using System.ComponentModel.DataAnnotations;

namespace VoteCounter.Data.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public int VoteCount { get; set; } = 0;
    }
}