using Scolus.Data.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolus.Data.Entities
{
    public class UserAccount : IAudit
    {
        [Key]
        public int AccountId { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Salt { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string UpdatedBy { get; set; }

        [Required]
        public DateTime UpdatedOn { get; set; }

        [Required]
        public bool IsActive { get; set; }
    }
}
