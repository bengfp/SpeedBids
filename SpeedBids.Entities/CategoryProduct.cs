using Microsoft.EntityFrameworkCore;

namespace SpeedBids.Entities;

[PrimaryKey(nameof(ProductId), nameof(CategoryId))]

public class CategoryProduct
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
}
