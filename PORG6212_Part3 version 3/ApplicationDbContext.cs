using Microsoft.EntityFrameworkCore;
using PORG6212_Part3_version_3.Models;

namespace PORG6212_Part3_version_3
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<LecturerClaim> LecturerClaims { get; set; }
    }
}
