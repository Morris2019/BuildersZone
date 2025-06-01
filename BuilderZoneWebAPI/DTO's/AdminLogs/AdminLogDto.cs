using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.AdminLogs
{
   public class AdminLogDto
    {
        public string Id { get; set; } = null!;
        public string AdminId { get; set; } = null!;
        public string Action { get; set; } = null!;
        public string TargetEntity { get; set; } = null!;
        public string TargetId { get; set; } = null!;
        public object Metadata { get; set; } = null!;
        public DateTime Timestamp { get; set; }
    }
}