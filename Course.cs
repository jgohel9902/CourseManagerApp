using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseManagerApp.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Instructor { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public string RoomNumber { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
