﻿using System.ComponentModel.DataAnnotations;

namespace SpeedBids.Entities;

public class Category
{
    [Key]
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();
}
