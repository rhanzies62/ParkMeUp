using Scolus.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scolus.Data.Entities
{
    //TODO : Foreign Key
    //TODO : Entity Property for each foreigh key
    public class Faculty : BaseUser
    {
        public Faculty()
        {

        }

        [Key]
        public int FacultyId { get; set; }

        [Required]
        [ForeignKey("School")]
        public int SchoolId { get; set; }

        [Required]
        [ForeignKey("Position")]
        public int PositionId { get; set; }

        [Required]
        [ForeignKey("Address")]
        public int AddressId { get; set; }

        [Required]
        public int PhoneId { get; set; }

        public string EmailAddress { get; set; }

        public virtual School School { get; set; }
        public virtual Position Position { get; set; }
        public virtual Address Address { get; set; }
        public virtual ICollection<FacultyCustomFieldValue> FacultyCustomFieldValues { get; set; }
    }
}
