using System.Net.Http.Headers;

namespace PustokProject.CoreModels
{
    public class BookImage : BaseModel
    {
        
        public string ImagePath { get; set; }
        public bool IsActive { get; set; }

        public int BooktId { get; set; }
        public Book Book { get; set; }

    }
}
