using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.AdminLogs
{
   public class UpdateAdminLogDto
    {
        public string? Action { get; set; }
        public string? TargetEntity { get; set; }
        public string? TargetId { get; set; }
        public object? Metadata { get; set; }
    }
}