using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PustokProject.ViewModels.Author
{
    public class VM_AuthorsIndex
    {
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Surname { get; set; }
    }
}
