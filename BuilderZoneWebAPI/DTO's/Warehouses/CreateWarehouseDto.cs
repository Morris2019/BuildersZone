using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Warehouses
{
    public class CreateWarehouseDto
    {
        [Required]
        public string Name { get; set; }

        public object Address { get; set; }
        public object ContactInfo { get; set; }
        public bool IsActive { get; set; } = true;
    }
}