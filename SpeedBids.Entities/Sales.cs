using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpeedBids.Entities;

[PrimaryKey(nameof(CarAuctionId))]
public class Sales
{
    [Key]
    public int SalesId { get; set; }

    public int CarAuctionId { get; set; }

    [ForeignKey("User")]
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
}
