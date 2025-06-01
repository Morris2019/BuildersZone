using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BuilderZoneWebAPI.DTOs.UsersProfileImages
{
    public class UpdateUserProfileImageDto
    {
        public string ImageUrl { get; set; }
        public bool? IsPrimary { get; set; }
        public string ImageType { get; set; }
        public object Metadata { get; set; }
    }
}