using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using PORG6212_Part3_version_3.Models;

namespace PORG6212_Part3_version_3.Controllers
{
    public class LecturerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LecturerController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult SubmitClaim()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SubmitClaim(LecturerClaim claim)
        {
            if (ModelState.IsValid)
            {
                claim.TotalPayment = claim.HoursWorked * claim.HourlyRate;
                _context.LecturerClaims.Add(claim);
                await _context.SaveChangesAsync();
                TempData["SuccessMessage"] = "Claim submitted successfully!";
                return RedirectToAction(nameof(SubmitClaim));
            }

            return View(claim);
        }
    }
}
