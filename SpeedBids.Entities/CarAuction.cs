using System.ComponentModel.DataAnnotations;

namespace SpeedBids.Entities;
public class CarAuction
{
    [Key]
    public int CarAuctionId { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();
    public List<Bid> Bids { get; set; } = new List<Bid>();
}