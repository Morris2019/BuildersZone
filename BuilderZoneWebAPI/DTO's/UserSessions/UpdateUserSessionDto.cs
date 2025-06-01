using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.UserSessionDtos
{
    public class UpdateUserSessionDto
    {
        public bool? IsRevoked { get; set; }
    }
}