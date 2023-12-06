using Microsoft.Build.Evaluation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mime;

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

        public List<BookImage> Images { get; set; } = new();

        public void SetActiveImage(int imageId)
        {
            Images.ForEach(i=>i.DeActivate());
            var image = Images.FirstOrDefault(i=>i.Id == imageId);
            if (image != null)
            {
                image.Activate();
                CoverImageUrl = image.ImagePath;
            }
        }
        
        [NotMapped]
        public decimal? DiscountedPrice { get => DiscountPercentage != null ? Price * (1 - DiscountPercentage / 100) : null; }

        

    }
}
