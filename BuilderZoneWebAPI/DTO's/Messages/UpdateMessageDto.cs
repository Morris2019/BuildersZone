using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.Messages
{
   public class UpdateMessageDto
    {
        public string Message { get; set; }
        public object Attachments { get; set; }
    }
}