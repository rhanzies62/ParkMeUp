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
    //TODO: FacultyCustomFieldSetUpID and FacultyId should not be duplicated
    //TODO: If the required property in FacultyCustomFieldSetUpID is true, value should not be null or empty
    public class FacultyCustomFieldValue : IAudit
    {
        [Key]
        public int FacultyCustomFieldValueId { get; set; }

        [Required]
        [ForeignKey("FacultyCustomFieldSetUp")]
        public int FacultyCustomFieldSetUpId { get; set; }

        [Required]
        [ForeignKey("Faculty")]
        public int FacultyID { get; set; }

        public string Value { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string UpdatedBy { get; set; }

        [Required]
        public DateTime UpdatedOn { get; set; }

        public virtual FacultyCustomFieldSetUp FacultyCustomFieldSetUp { get; set; } 
        public virtual Faculty Faculty { get; set; }
    }
}
