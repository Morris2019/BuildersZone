using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.MaterialCategories
{
    public class MaterialCategoryDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public object Attributes { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}