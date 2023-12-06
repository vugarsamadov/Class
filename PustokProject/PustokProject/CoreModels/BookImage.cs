using System.Net.Http.Headers;

namespace PustokProject.CoreModels
{
    public class BookImage : BaseModel
    {
        
        public string ImagePath { get; set; }
        public bool IsActive { get; private set; }

        public void Activate()
        {
            IsActive = true;
        }
        
        public void DeActivate()
        {
            IsActive = false;
        }
        
        
        
        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}
