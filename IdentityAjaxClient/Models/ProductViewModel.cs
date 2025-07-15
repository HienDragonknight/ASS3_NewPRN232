using System.ComponentModel.DataAnnotations;

namespace IdentityAjaxClient.Models
{
    public class ProductViewModel
    {
        public int? OrchidId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string OrchidName { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Image URL is required")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Category ID is required")]
        public int CategoryId { get; set; }
    }
}