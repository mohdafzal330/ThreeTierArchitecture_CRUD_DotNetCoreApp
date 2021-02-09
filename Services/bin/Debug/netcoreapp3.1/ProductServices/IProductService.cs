using System.Collections.Generic;
using Models.ViewModels;

namespace Services
{
    public interface IProductService
    {
        List<ProductViewModel> GetAllProducts();
        bool DeleteProduct(long id);
    }
}