using Core;

namespace Entities.DTOs;

public class ProductDetailDto:IDto //DTO"lar verileri filtrelemeye yarıyor aslında 
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }        
    public int UnitInStock { get; set; }
    
}