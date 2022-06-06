using Core;

namespace Entities.DTOs;

public class ProductDetailDto:IDto
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }        
    public int UnitInStock { get; set; }
    
}