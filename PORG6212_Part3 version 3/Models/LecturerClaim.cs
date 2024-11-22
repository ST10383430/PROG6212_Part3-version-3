using System.ComponentModel.DataAnnotations;

namespace PORG6212_Part3_version_3.Models
{
    public class LecturerClaim
    {
        public int Id { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Hours must be between 1 and 100.")]
        public int HoursWorked { get; set; }

        [Required]
        [Range(10, 500, ErrorMessage = "Hourly Rate must be between 10 and 500.")]
        public decimal HourlyRate { get; set; }

        public decimal TotalPayment { get; set; }

        [Required]
        public string Status { get; set; } = "Pending";
    }
}
