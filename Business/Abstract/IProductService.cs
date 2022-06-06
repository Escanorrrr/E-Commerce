using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface IProductService
{
    
    IDataResult<Product> GetById(int productId);
    IDataResult<List<Product>> GetList();
    IDataResult<List<Product>> GetListByCategory(int categoryId);
    IResult Add(Product product);
    IResult Update(Product product);
    IResult Delete(Product product);
    IDataResult<List<ProductDetailDto>> GetProductDetails();
}