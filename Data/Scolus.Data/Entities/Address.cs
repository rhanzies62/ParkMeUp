using Scolus.Data.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolus.Data.Entities
{
    public class Address : IAudit
    {
        [Key]
        public int AddressId { get; set; }

        [Required]
        public string StreetNumber { get; set; }

        [Required]
        public string StreetName { get; set; }

        [Required]
        public string StreetAddress { get; set; }

        public string StreetAddress2 { get; set; }

        [Required]
        public string City { get; set; }

        public string PostalCode { get; set; }

        [Required]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        [Required]
        public string UpdatedBy { get; set; }

        [Required]
        public DateTime UpdatedOn { get; set; }

        public virtual ICollection<Faculty> Faculty { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
