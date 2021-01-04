using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace InredningOnline.Models
{
    public class Project
    {

        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int DesignerId { get; set; }
        public Designer Designer { get; set; }
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