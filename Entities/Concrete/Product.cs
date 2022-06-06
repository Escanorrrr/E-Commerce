using Core;

namespace Entities.Concrete;

public class Product:IEntity
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public int CategoryId { get; set; }
    public int BrandId { get; set; }      
    public decimal UnitPrice { get; set; }
    public int UnitInStock { get; set; }
}