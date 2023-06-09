﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SpeedBids.Entities;

public class ApplicationUser : IdentityUser
{
    [StringLength(100)]
    public string FirstName { get; set; }

    [StringLength(100)]
    public string LastName { get; set; }

    public List<Bid> Bids { get; set; } = new List<Bid>();
}
