using SpeedBids.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace SpeedBids.Entities;

public class Car
{
    [Key]
    public int CarId { get; set; }
    public ECarMake CarMake { get; set; }

    [StringLength(50)]
    public string CarModel { get; set; }

    public ECarType CarType { get; set; }

    public EColor Color { get; set; }

    public int YearModel { get; set; }
}
