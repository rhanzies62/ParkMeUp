using Scolus.Data.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolus.Data.Entities
{
    //TODO: Foreign Key
    //TODO: StudentCustomFieldSetUpId and StudentID should not be duplicated
    //TODO: If the required property in StudentCustomFieldSetUp is true, value should not be null or empty
    public class StudentCustomFieldValue : IAudit
    {
        [Key]
        public int StudentCustomFieldValueId { get; set; }

        [Required]
        [ForeignKey("StudentCustomFieldSetUp")]
        public int StudentCustomFieldSetUpId { get; set; }

        [Required]
        [ForeignKey("Student")]
        public int StudentID { get; set; }

        public string Value { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string UpdatedBy { get; set; }

        [Required]
        public DateTime UpdatedOn { get; set; }

        public virtual StudentCustomFieldSetUp StudentCustomFieldSetUp { get; set; }
        public virtual Student Student { get; set; }
    }
}
