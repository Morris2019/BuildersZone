using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.FraudReports
{
     public class CreateFraudReportDto
    {
        [Required] public string ReporterId { get; set; }
        [Required] public string ReportedEntityType { get; set; }
        [Required] public string ReportedEntityId { get; set; }
        [Required] public string Reason { get; set; }
    }
}
