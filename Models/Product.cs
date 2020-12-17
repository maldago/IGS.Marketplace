using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IntelligentGrowthSolutions.Marketplace.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Price { get; set; }
    }
}
