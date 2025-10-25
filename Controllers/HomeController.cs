using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VoteCounter.Data;

namespace VoteCounter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Load all candidates from the database for the home page
            var candidates = await _context.Candidates.ToListAsync();
            return View(candidates);
        }
    }
}