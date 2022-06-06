using FrontToBack.Models;
using System.Collections.Generic;

namespace FrontToBack.ViewModels
{
    public class HomeVm
    {
        public IEnumerable<Slider> slider { get; set; }
        public PageIntro pageIntro { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
    }
}
