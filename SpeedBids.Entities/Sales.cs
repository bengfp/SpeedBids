using System.ComponentModel.DataAnnotations;

namespace SpeedBids.Entities;
public class Sales
{
    [Key]
    public int SalesId { get; set; }

    public List<Bid> Bids { get; set; } = new List<Bid>();
}
