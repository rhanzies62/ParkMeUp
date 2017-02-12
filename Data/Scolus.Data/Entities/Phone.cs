using Scolus.Data.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolus.Data.Entities
{
    public class Phone : IAudit
    {
        [Key]
        public int PhoneId { get; set; }

        [Required]
        [MaxLength(11)]
        public string Number { get; set; }

        public string Extension { get; set; }

        [Required]
        public PhoneType Type { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string UpdatedBy { get; set; }

        [Required]
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<Student> Student { get; set; }
    }
}
