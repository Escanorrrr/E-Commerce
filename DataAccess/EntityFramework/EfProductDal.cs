using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.EntityFramework;

public class EfProductDal:EfEntityRepositoryBase<Product, ShoppingContext>, IProductDal
{
    public List<ProductDetailDto> GetProductDetails()
    {
        using (ShoppingContext context = new ShoppingContext())
        {
            var result = from p in context.Products
                join c in context.Categories
                    on p.CategoryId equals c.Id
                select new ProductDetailDto { ProductId = p.Id, ProductName = p.ProductName, UnitInStock = p.UnitInStock};
                
            return result.ToList(); //Burada sql tablolarıyla detaildto içinde ki verileri matchliyoruz aslında sql sorgusu tarzı
        };          
    }
}