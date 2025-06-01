using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Inventory
{
    public class CreateInventoryDto
    {
        [Required]
        public string ProductId { get; set; }

        [Required]
        public string WarehouseId { get; set; }

        [Required]
        public int Stock { get; set; }

        public object Location { get; set; }
    }
}