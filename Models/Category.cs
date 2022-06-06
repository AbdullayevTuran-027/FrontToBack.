using System.Collections.Generic;

namespace FrontToBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Product>Producty { get; set; }
    }
}
