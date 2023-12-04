using PustokProject.CoreModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace PustokProject.ViewModels
{
    public class VM_CreateBook
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public string ProductCode { get; set; }
        public bool IsAvailable { get; set; }
        public string CoverImageUrl { get; set; }
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(5,4)")]
        public decimal DiscountPercentage { get; set; }

    }
}
