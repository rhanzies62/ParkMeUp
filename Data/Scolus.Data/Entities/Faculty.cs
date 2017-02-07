using Scolus.Data.Base;
using System.ComponentModel.DataAnnotations;

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
        public int SchoolId { get; set; }

        [Required]
        public int PositionId { get; set; }

        [Required]
        public int AddressId { get; set; }

        [Required]
        public int PhoneId { get; set; }
    }
}
