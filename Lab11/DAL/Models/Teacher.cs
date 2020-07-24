using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
    public class Teacher : IEquatable<Teacher>
    {
        public Teacher()
        {

        }

        public Int32 TeacherId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public String TeacherName { get; set; }

        [Required]
        [Range(0, 50)]
        public Int32 WorkExperience { get; set; }

        [Range(17, 70)]
        public Int32 TeacherAge { get; set; }

        public Byte[] TeacherPhoto { get; set; }

        public override String ToString() => 
            $"Teacher id:{TeacherId}{Environment.NewLine}Name:{TeacherName}{Environment.NewLine}Age:{TeacherAge}{Environment.NewLine}Work experience:{WorkExperience}{Environment.NewLine}";

        public bool Equals(Teacher other)
        {
            return TeacherName == other.TeacherName &&
                TeacherAge == other.TeacherAge &&
                WorkExperience == other.WorkExperience;
        }
    }
}
