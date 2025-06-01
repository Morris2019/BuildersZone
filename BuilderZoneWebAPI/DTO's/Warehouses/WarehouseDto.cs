using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Warehouses
{
    public class WarehouseDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public object Address { get; set; }
        public object ContactInfo { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}