using Microsoft.AspNetCore.Mvc;
using VoteCounter.Data;
using VoteCounter.Data.Models;

namespace VoteCounter.Controllers
{
    public class CandidatesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CandidatesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Home page
        public IActionResult Index()
        {
            var candidates = _context.Candidates.ToList();
            return View(candidates);
        }

        // Candidate details
        public IActionResult Details(int id)
        {
            var candidate = _context.Candidates.FirstOrDefault(c => c.Id == id);
            if (candidate == null)
                return NotFound();

            return View(candidate);
        }

        // GET: Vote page
        [HttpGet]
        public IActionResult Vote(int id)
        {
            var candidate = _context.Candidates.FirstOrDefault(c => c.Id == id);
            if (candidate == null)
                return NotFound();

            var vote = new Vote
            {
                CandidateId = candidate.Id,
                Candidate = candidate // ✅ това гарантира, че View получава Candidate
            };

            return View(vote);
        }




        [HttpPost]
        public IActionResult VoteConfirmed(Vote vote)
        {
           // if (!ModelState.IsValid)
              //  return View("Vote", vote);

            var candidate = _context.Candidates.FirstOrDefault(c => c.Id == vote.CandidateId);
            if (candidate == null)
                return NotFound();

            // ✅ Проверка дали този имейл вече е гласувал
            var alreadyVoted = _context.Votes.Any(v => v.Email.ToLower() == vote.Email.ToLower());
            if (alreadyVoted)
            {
                TempData["VoteMessage"] = "Този имейл вече е използван за гласуване!";
                return RedirectToAction("Index");
            }

            // ✅ Ако е нов имейл → записваме гласа
            candidate.VoteCount++;
            _context.Votes.Add(vote);
            _context.SaveChanges();

            TempData["VoteMessage"] = $"Успешно гласувахте за {candidate.Name}!";

            return RedirectToAction("Index");
        }



    }
}
