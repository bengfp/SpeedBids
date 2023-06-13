using SpeedBids.Entities.Enums;

namespace SpeedBids.WebUI.Models
{
	public class BidViewModel
	{
		public int ProductId { get; set; }
		public ECarMake CarMake { get; set; }
		public string CarModel { get; set; }

		public ECarType CarType { get; set; }

		public EColor Color { get; set; }

		public int YearModel { get; set; }

		public string ProductDescription { get; set; }
		public float ProductPrice { get; set; }
		public string ProductImage { get; set; }
	}
}
