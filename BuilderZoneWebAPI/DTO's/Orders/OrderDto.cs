using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BuildersZone.API.DTOs.Orders;

namespace BuilderZoneWebAPI.DTOs.Orders
{
   public class OrderDto
    {
        public string Id { get; set; } = null!;
        public string BuyerId { get; set; } = null!;
        public string ShopId { get; set; } = null!;
        public List<OrderItemDto> Items { get; set; } = new List<OrderItemDto>();
        public string DeliveryMethod { get; set; } = null!;
        public object DeliveryAddress { get; set; } = null!;
        public string? DeliveryPartnerId { get; set; }
        public string Status { get; set; } = null!;
        public object? DeliveryCoordinates { get; set; }
        public DateTime EstimatedDeliveryTime { get; set; }
        public DateTime OrderPlacedAt { get; set; }
        public DateTime OrderUpdatedAt { get; set; }
        public decimal TotalAmount { get; set; }
    
    }
     
}
