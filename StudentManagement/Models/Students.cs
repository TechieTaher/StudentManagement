using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentManagement.Models
{
    public partial class Students
    {
        public Students()
        {
            StudentCourses = new HashSet<StudentCourses>();
        }

        [Key]
        public int StudentId { get; set; }
        [Required]
        [StringLength(50)]
        public string StudentName { get; set; }
        public long MobileNo { get; set; }
        [Required]
        [StringLength(50)]
        public string EmailId { get; set; }
        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }
        public int Gender { get; set; }
        [Required]
        [StringLength(50)]
        public string Address { get; set; }
        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [InverseProperty("Student")]
        public virtual ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
