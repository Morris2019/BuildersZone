using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BuildersZone.API.DTOs.Orders;

namespace BuilderZoneWebAPI.DTOs.Orders
{
   public class UpdateOrderDto
    {
        public string? BuyerId { get; set; }
        public string? ShopId { get; set; }
        public List<OrderItemDto>? Items { get; set; }
        public string? DeliveryMethod { get; set; }
        public object? DeliveryAddress { get; set; }
        public string? DeliveryPartnerId { get; set; }
        public string? Status { get; set; }
        public object? DeliveryCoordinates { get; set; }
        public DateTime? EstimatedDeliveryTime { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}