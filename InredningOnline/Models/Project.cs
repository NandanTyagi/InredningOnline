using System.Collections.Generic;
using System.Linq;

namespace InredningOnline.Models
{
    public class Project
    {

        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
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