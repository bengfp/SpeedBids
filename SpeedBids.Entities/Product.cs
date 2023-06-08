using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpeedBids.Entities;

[PrimaryKey(nameof(CarId))]
public class Product
{
    [Key]
    public int ProductId { get; set; }
    [ForeignKey("Car")]
    public int CarId { get; set; }
    public Car Car { get; set; }

    [StringLength(200)]
    public string ProductDescription { get; set; }
    public float ProductPrice { get; set; }
    public string ProductImage { get; set; }
    public List<Category> Categories { get; set; } = new List<Category>();
}
