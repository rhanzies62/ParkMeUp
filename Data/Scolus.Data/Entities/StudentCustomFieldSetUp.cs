using Scolus.Data.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolus.Data.Entities
{
    //TODO: Foreign Key
    //TODO: School ID and CustomFieldID should not be duplicated
    public class StudentCustomFieldSetUp : IAudit
    {
        [Key]
        public int StudentCustomFieldSetUpId { get; set; }

        [Required]
        public int SchoolId { get; set; }

        [Required]
        public int CustomFieldId { get; set; }

        [Required]
        public bool Required { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string UpdatedBy { get; set; }

        [Required]
        public DateTime UpdatedOn { get; set; }
    }
}
