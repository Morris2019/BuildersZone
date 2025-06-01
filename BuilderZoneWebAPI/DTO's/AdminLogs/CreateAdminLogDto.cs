using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.AdminLogs
{
    public class CreateAdminLogDto
    {
        [Required] public string AdminId { get; set; } = null!;
        [Required] public string Action { get; set; } = null!;
        public string? TargetEntity { get; set; }
        public string? TargetId { get; set; }
        public object? Metadata { get; set; }
    }
}