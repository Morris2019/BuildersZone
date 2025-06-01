using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.FraudReports
{
    public class FraudReportDto
    {
        public string Id { get; set; }
        public string ReporterId { get; set; }
        public string ReportedEntityType { get; set; }
        public string ReportedEntityId { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
