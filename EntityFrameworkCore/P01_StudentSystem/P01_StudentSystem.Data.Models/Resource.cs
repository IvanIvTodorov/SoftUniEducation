using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    public class Resource
    {
        public enum ResourceTypes
        {
            Video,
            Presentation,
            Document,
            Other
        };


        [Key]
        public int ResourceId { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public ResourceTypes ResourceType { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }

    }
}
