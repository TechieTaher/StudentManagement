using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Models
{
    public partial class Courses
    {
        public Courses()
        {
            StudentCourses = new HashSet<StudentCourses>();
        }

        [Key]
        public int CourseId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(300)]
        public string Description { get; set; }
        public int TimePeriod { get; set; }

        [InverseProperty("Course")]
        public virtual ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
