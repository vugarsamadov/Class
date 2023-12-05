namespace PustokProject.CoreModels
{
    public class BaseModel
    {
        public int Id { get; set; }
        public bool IsDeleted { get; private set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public void Delete()
        {
            IsDeleted = true;
        }
        public void RevokeDelete()
        {
            IsDeleted = false;
        }
    }
}
