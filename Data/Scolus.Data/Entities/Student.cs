using Scolus.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace Scolus.Data.Entities
{
    //TODO: Foreign Key
    //TODO: StudentType should be the ID in entity look up
    public class Student : BaseUser
    {
        public Student()
        {

        }

        [Key]
        public int StudentID { get; set; }

        [Required]
        public int SchoolId { get; set; }

        [Required]
        public int StudentType { get; set; }

        [Required]
        public int AddressId { get; set; }

        [Required]
        public int PhoneId { get; set; }

        public string EmailAddress { get; set; }
    }
}
