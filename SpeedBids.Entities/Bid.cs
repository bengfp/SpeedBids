using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpeedBids.Entities
{
    public class Bid
    {
        [Key]
        public int BidId { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public float BidAmount { get; set; }

        [ForeignKey("CarAuction")]
        public int CarAuctionId { get; set; }
        public CarAuction CarAuction { get; set; }
    }
}
