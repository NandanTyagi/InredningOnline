using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace InredningOnline.Models
{
    public class Project
    {

        // Properties
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter name of project")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "User Id")]
        public int UserId { get; set; }
        public User User { get; set; }
        public IEnumerable<Material> Materials { get; set; }

        public decimal GetTotalCost()
        {
            decimal total = 0;

            foreach (var material in this.Materials)
            {
                total += material.Price * material.Amount;
            }

            return total;
        }
    }
}