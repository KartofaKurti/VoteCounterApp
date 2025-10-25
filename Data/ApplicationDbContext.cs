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

            // Seed 3 candidates for testing
            modelBuilder.Entity<Candidate>().HasData(
                new Candidate
                {
                    Id = 1,
                    Name = "Кандидат 1",
                    Description = "Опитен лидер с визия за бъдещето.",
                    ImageUrl = "/images/candidate1.jpg",
                    VoteCount = 0
                },
                new Candidate
                {
                    Id = 2,
                    Name = "Кандидат 2",
                    Description = "Млад и амбициозен с нови идеи.",
                    ImageUrl = "/images/candidate2.jpg",
                    VoteCount = 0
                },
                new Candidate
                {
                    Id = 3,
                    Name = "Кандидат 3",
                    Description = "Човек на действието и резултатите.",
                    ImageUrl = "/images/candidate3.jpg",
                    VoteCount = 0
                }
            );
        }
    }
}