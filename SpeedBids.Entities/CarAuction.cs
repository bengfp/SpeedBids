using System.ComponentModel.DataAnnotations;

namespace SpeedBids.Entities;
public class CarAuction
{
    [Key]
    public int CarAuctionId { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public float Amount { get; set; }

    public List<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    public List<Product> Products { get; set; } = new List<Product>();
}
