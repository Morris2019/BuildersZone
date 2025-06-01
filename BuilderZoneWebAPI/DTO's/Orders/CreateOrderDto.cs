using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BuildersZone.API.DTOs.Orders;

namespace BuilderZoneWebAPI.DTOs.Orders
{
    public class CreateOrderDto
    {
        [Required] public string BuyerId { get; set; } = null!;
        [Required] public string ShopId { get; set; } = null!;
        [Required] public List<OrderItemDto> Items { get; set; } = new List<OrderItemDto>();
        [Required] public string DeliveryMethod { get; set; } = "Standard";
        [Required] public object DeliveryAddress { get; set; } = null!;
        public string? DeliveryPartnerId { get; set; }
        [Required] public string Status { get; set; } = "Pending";
        [Required] public decimal TotalAmount { get; set; }
    }
}