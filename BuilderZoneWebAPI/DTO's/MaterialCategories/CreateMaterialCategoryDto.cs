using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.MaterialCategories
{
    public class CreateMaterialCategoryDto
    {
        [Required]
        public string Name { get; set; }
        public object Attributes { get; set; }
    }
}