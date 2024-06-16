﻿namespace PortsAndAdapters.Application.Model;

public class Order
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public List<OrderItem> Items { get; set; } = [];
}