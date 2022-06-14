using Business.Abstract;
using Business.Constants;
using Business.Constants.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;

namespace Business.Concrete;

public class ProductManager:IProductService
{
    private IProductDal _productDal;
    private ICategoryService _categoryService;
    
    public ProductManager(IProductDal productDal,ICategoryService categoryService)
    {
        _productDal = productDal;
        _categoryService = categoryService;
    }
        
    [ValidationAspect((typeof(ProductValidator)))] //Burada validate kısmını yazdık
    public IResult Add(Product product)
    {
        _productDal.Add(product);
        return new Result(true,"Ürün Eklendi");
    }

    public IResult Delete(Product product)
    {
        _productDal.Delete(product);
        return new Result(true, "Ürün Silindi");
    }

    public IDataResult<Product> GetById(int productId)
    {
        return new SuccessDataResult<Product>(_productDal.Get(p => p.Id == productId),Messages.ProductListed);
    }

    public IDataResult<List<Product>> GetList()
    {
        return new SuccessDataResult<List<Product>>(_productDal.GetList(),Messages.ProductListed);
    }

    public IDataResult<List<Product>> GetListByCategory(int categoryId)
    {
        return new DataResult<List<Product>> (_productDal.GetList(p => p.CategoryId == categoryId).ToList(),true,"Kategoriler Listelendi");
    }

    public IDataResult<List<ProductDetailDto>> GetProductDetails()
    {
        return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
    }

    public IResult Update(Product product)
    {
        _productDal.Update(product);
        return new SuccessResult(Messages.ProductUpdated);
    }
}