using Microsoft.Build.Evaluation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PustokProject.CoreModels
{
    public class Book : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        public int BrandId { get; set; }
        public Brand Brand { get; set; } 
        public string ProductCode { get; set; }
        public bool IsAvailable { get; set; }

        public string CoverImageUrl{ get; set; }

        public decimal Price { get; set; }

        [Column(TypeName= "decimal(4,2)")]
        public decimal? DiscountPercentage { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public IEnumerable<BookImage> Images { get; set; }

        [NotMapped]
        public decimal? DiscountedPrice { get => DiscountPercentage != null ? Price * (1 - DiscountPercentage / 100) : null; }

        

    }
}
