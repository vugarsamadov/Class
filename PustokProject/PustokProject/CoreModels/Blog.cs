namespace PustokProject.CoreModels
{
    public class Blog : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthordId { get; set; }
        public Author Author { get; set; }

    }
}
