using System.ComponentModel.DataAnnotations;

namespace InredningOnline.Models
{
    public class Material
    {
        public int Id { get; set; }

        [Display(Name = "Project Id")]
        public int ProjectId { get; set; }

        [Required(ErrorMessage = "Please enter material name")]
        [StringLength(15)]
        public string Name { get; set; }

        [StringLength(15)]
        public string Supplier { get; set; }

        [Required(ErrorMessage = "Please enter price")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter amount")]
        public int Amount { get; set; }
        
        [StringLength(23)]
        public string Details { get; set; }


    }

}