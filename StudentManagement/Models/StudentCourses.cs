using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Models
{
    public partial class StudentCourses
    {
        public StudentCourses()
        {
            Fees = new HashSet<Fees>();
        }

        [Key]
        public int StudentCourseId { get; set; }
        public int StudentId { get; set; }
        [Column("CourseID")]
        public int CourseId { get; set; }

        [ForeignKey(nameof(CourseId))]
        [InverseProperty(nameof(Courses.StudentCourses))]
        public virtual Courses Course { get; set; }
        [ForeignKey(nameof(StudentId))]
        [InverseProperty(nameof(Students.StudentCourses))]
        public virtual Students Student { get; set; }
        [InverseProperty("StudentCourse")]
        public virtual ICollection<Fees> Fees { get; set; }
    }
}
