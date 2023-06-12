using SpeedBids.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace SpeedBids.Entities;

public class Product
{
	[Key]
	public int ProductId { get; set; }
	public ECarMake CarMake { get; set; }

	[StringLength(50)]
	public string CarModel { get; set; }

	public ECarType CarType { get; set; }

	public EColor Color { get; set; }

	public int YearModel { get; set; }

	[StringLength(200)]
	public string ProductDescription { get; set; }
	public float ProductPrice { get; set; }
	public string ProductImage { get; set; }
	public List<Category> Categories { get; set; } = new List<Category>();
}
