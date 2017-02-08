using Scolus.Data.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolus.Data.Entities
{
    //TODO : Forgein Key
    //TODO : CustomFieldId and Text should not be duplicated
    public class CustomFieldOption : IAudit
    {
        [Key]
        public int CustomFieldOptionId { get; set; }

        [Required]
        public int CustomFieldId { get; set; }

        [Required]
        public string Text { get; set; }

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
