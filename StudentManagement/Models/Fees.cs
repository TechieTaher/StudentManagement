using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Models
{
    public partial class Fees
    {
        [Key]
        public int FeeId { get; set; }
        public int StudentCourseId { get; set; }
        public int Amount { get; set; }
        [Column(TypeName = "date")]
        public DateTime PaymentDate { get; set; }

        [ForeignKey(nameof(StudentCourseId))]
        [InverseProperty(nameof(StudentCourses.Fees))]
        public virtual StudentCourses StudentCourse { get; set; }
    }
}
