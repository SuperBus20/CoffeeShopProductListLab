using CoffeeShopProductListLab.Models;
using System.Text.Encodings.Web;

namespace CoffeeShopProductListLab
{
    public class ProductRepository
    {
        private List<ProductViewModel> _mockProducts;

        public ProductRepository()
        {
            CreateMockProductList();
        }

        private void CreateMockProductList()
        {
            _mockProducts = new List<ProductViewModel>();
            _mockProducts.Add(new ProductViewModel { Id = 1, Name = "Java",Price=129.99, Description = "A nice and bold cup of coffee for your average hipster" });
            _mockProducts.Add(new ProductViewModel { Id = 2, Name = "Folgers",Price=2.99, Description = "You might as well be drinking dirt water" });
            _mockProducts.Add(new ProductViewModel { Id = 3, Name = "Comumbian Hand Ground Mahogany Roast",Price=999.01, Description = "The nectar of the gods. when you drink this you can taste the tears of angels and hear heaven weep at its majesty." });
        }

        public IEnumerable<ProductViewModel> GetMockProducts() 
        {
            return _mockProducts;
        }
    }
}
