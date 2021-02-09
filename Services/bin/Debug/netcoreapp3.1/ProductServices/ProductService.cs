using System;
using System.Collections.Generic;
using System.Linq;
using Models.Context;
using Models.ViewModels;
namespace Services
{
    public class ProductService : IProductService
    {
        private readonly AppDBContext _context;
        public ProductService(AppDBContext context)
        {
            _context = context;
        }
        public List<ProductViewModel> GetAllProducts()
        {
            try
            {
                var products = _context.Products.Where(p => p.RowStatus == 1)
                .Select(res => new ProductViewModel
                {
                    PkProductId = res.PkProductId,
                    ProductName = res.ProductName,
                    ProductDescription = res.ProductDescription,
                    CategoryName = "New Category",
                    ProductPrice = res.ProductPrice
                })
                .ToList();
                return products;
            }
            catch (Exception ex)
            {
                var s = ex.Message;
                //log exeptions
                return null;
            }
        }
        public bool DeleteProduct(long id)
        {
            try
            {
                var products = _context.Products.Where(p => p.PkProductId == id).FirstOrDefault();

                if (products == null) return false;
                products.RowStatus = 0;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                var s = ex.Message;
                //log exeptions
                return false;
            }
        }
    }
}
