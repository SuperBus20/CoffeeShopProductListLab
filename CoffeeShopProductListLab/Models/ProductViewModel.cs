using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShopProductListLab.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [DisplayName("Product Name")]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public  double Price { get; set; }
        public string Description { get; set; }
    }
}
