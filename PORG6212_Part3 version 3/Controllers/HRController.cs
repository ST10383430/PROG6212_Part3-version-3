using Microsoft.AspNetCore.Mvc;
using System.Linq;
using PORG6212_Part3_version_3.Data;

namespace PORG6212_Part3_version_3.Controllers
{
    public class HRController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HRController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult FinalizeClaims()
        {
            var approvedClaims = _context.LecturerClaims.Where(c => c.Status == "Approved").ToList();
            return View(approvedClaims);
        }
    }
}
