namespace VoteCounter.Data.Models
{
    public class Vote
    {
        public int Id { get; set; }

        public string Email { get; set; } = string.Empty;

        public int CandidateId { get; set; }

        public Candidate Candidate { get; set; } = null!;
    }
}