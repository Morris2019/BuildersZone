using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Inventory
{
     public class InventoryDto
    {
        public string Id { get; set; }
        public string ProductId { get; set; }
        public string WarehouseId { get; set; }
        public int Stock { get; set; }
        public object Location { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}