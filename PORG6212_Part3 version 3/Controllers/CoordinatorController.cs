using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using PORG6212_Part3_version_3.Data;

namespace PORG6212_Part3_version_3.Controllers
{
    public class CoordinatorController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CoordinatorController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult VerifyClaims()
        {
            var claims = _context.LecturerClaims.ToList();
            return View(claims);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateStatus(int id, string status)
        {
            var claim = _context.LecturerClaims.FirstOrDefault(c => c.Id == id);
            if (claim != null)
            {
                claim.Status = status;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(VerifyClaims));
        }
    }
}
