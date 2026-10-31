using System.ComponentModel.DataAnnotations;

namespace TechDesk.Models
{
    public class Device
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The asset tag is required.")]
        [StringLength(10, ErrorMessage = "The asset tag must be at most 10 characters.")]
        [Display(Name = "Asset tag")]
        public string AssetTag { get; set; } = string.Empty;

        [Required(ErrorMessage = "The device name is required.")]
        [StringLength(50, ErrorMessage = "The device name must be at most 50 characters.")]
        [Display(Name = "Device name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "The category is required.")]
        [StringLength(20, ErrorMessage = "The category must be at most 20 characters.")]
        [Display(Name = "Category")]
        public string Category { get; set; } = string.Empty;

        [Range(2015, 2026, ErrorMessage = "The year bought must be from 2015 to 2026.")]
        [Display(Name = "Year bought")]
        public int PurchaseYear { get; set; }

        [Display(Name = "On loan?")]
        public bool IsOnLoan { get; set; }
    }
}