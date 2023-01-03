using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace P01_StudentSystem.Data.Models
{
    public class Homework
    {
        public enum ContentTypes
        {
            Application,
            Pdf,
            Zip
        };

        [Key]
        public int HomeworkId { get; set; }

        [Required]
        public string Content { get; set; }
        [Required]
        public ContentTypes ContentType { get; set; }
        [Required]
        public DateTime SubmissionTime { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}
