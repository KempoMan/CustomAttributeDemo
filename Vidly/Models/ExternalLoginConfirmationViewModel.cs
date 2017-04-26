using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Driver's License")]
        public string DrivingLicense { get; set; }

        [Required]
        [StringLength(255)]
        public string Phone { get; set; }
    }
}
