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
    //TODO : forgein key association
    public class Position : IAudit
    {
        [Key]
        public int PositionId { get; set; }

        [Required]
        [ForeignKey("School")]
        public int SchoolId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string UpdatedBy { get; set; }

        [Required]
        public DateTime UpdatedOn { get; set; }

        public virtual School School { get; set; }

        public virtual ICollection<Faculty> Faculties { get; set; }
    }
}
