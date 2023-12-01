using PustokProject.CoreModels;

namespace PustokProject.ViewModels
{
    public class VM_SlidersIndex
    {
        public string PageTitle { get; set; }
        public IEnumerable<Slider> Sliders { get; set; }
    }
}
