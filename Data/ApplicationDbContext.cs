using Microsoft.EntityFrameworkCore;
using VoteCounter.Data.Models;

namespace VoteCounter.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ✅ Real candidate data
            modelBuilder.Entity<Candidate>().HasData(
                new Candidate
                {
                    Id = 1,
                    Name = "Борислав Сапунджиев",
                    Description = "Амбициозен и всеотдаен човек с ясна визия за развитие и успех.",
                    ImageUrl = "/images/candidate1.jpg",
                    VoteCount = 0
                },
                new Candidate
                {
                    Id = 2,
                    Name = "Валентин Узунов",
                    Description = "Спокоен, решителен и вдъхновяващ лидер, готов да изслуша и помогне.",
                    ImageUrl = "/images/candidate2.jpg",
                    VoteCount = 0
                },
                new Candidate
                {
                    Id = 3,
                    Name = "Атанас Кьосеиванов",
                    Description = "Иновативен мислител с практичен подход и отдаденост на екипа.",
                    ImageUrl = "/images/candidate3.jpg",
                    VoteCount = 0
                }
            );
        }
    }
}