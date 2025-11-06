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
                    Description = "Мъдър и далновиден лидер, който вярва в силата на знанието и последователните действия.",
                    ImageUrl = "/images/candidate1.jpg",
                    VoteCount = 0
                },
                new Candidate
                {
                    Id = 2,
                    Name = "Валентин Узунов",
                    Description = "Решителен и справедлив защитник на свободата на словото и обществения диалог.",
                    ImageUrl = "/images/candidate2.jpg",
                    VoteCount = 0
                },
                new Candidate
                {
                    Id = 3,
                    Name = "Атанас Кьосеиванов",
                    Description = "Идеалист с вяра в общността и социалната справедливост.",
                    ImageUrl = "/images/candidate3.jpg",
                    VoteCount = 0
                }
            );


        }
    }
}