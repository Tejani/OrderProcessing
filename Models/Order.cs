﻿namespace OrderProcessing.Models;

public class Order
{
    public int Id { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public DateTime CreatedAt { get; set; }
    public string Status { get; set; } // E.g., "Pending", "Confirmed"
}
