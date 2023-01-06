using System.ComponentModel;

namespace CoffeeShopProductListLab.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; }
        public  double Price { get; set; }
        public string Description { get; set; }
    }
}
