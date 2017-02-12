using Scolus.Data.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolus.Data.Entities
{
    public class School : IAudit
    {
        public School()
        {

        }

        [Key]
        public int SchoolId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public SchoolType Type { get; set; }

        [Required]
        public string ReferenceId { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string UpdatedBy { get; set; }

        [Required]
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<Position> Positions { get; set; }
        public virtual ICollection<SchoolCustomFieldSetUp> SchoolCustomFieldSetUps { get; set; }
        public virtual ICollection<Faculty> Faculties { get; set; }
        public virtual ICollection<FacultyCustomFieldSetUp> FacultyCustomFieldSetUp { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<StudentCustomFieldSetUp> StudentCustomFieldSetUp { get; set; }

    }
}
