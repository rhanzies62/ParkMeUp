using Scolus.Data.Base;
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

    //TODO : Forgein Key
    //TODO : CustomFieldI and SchoolID should not be duplicated
    //TODO : When inserting if Required property is True, Value should not be empty or null
    public class SchoolCustomFieldSetUp : IAudit
    {
        [Key]
        public int SchoolCustomFieldSetUpId { get; set; }

        [Required]
        [ForeignKey("School")]
        public int SchoolId { get; set; }

        [Required]
        [ForeignKey("CustomField")]
        public int CustomFieldId { get; set; }

        [Required]
        public bool Required { get; set; }

        public string Value { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string UpdatedBy { get; set; }

        [Required]
        public DateTime UpdatedOn { get; set; }

        public virtual School School { get; set; }
        public virtual CustomField CustomField { get; set; }
    }
}
