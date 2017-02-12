using Scolus.Data.Base;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey("School")]
        public int SchoolId { get; set; }

        [Required]
        public int StudentType { get; set; }

        [Required]
        [ForeignKey("Address")]
        public int AddressId { get; set; }

        [Required]
        [ForeignKey("Phone")]
        public int PhoneId { get; set; }

        public string EmailAddress { get; set; }

        public virtual School School { get; set; }
        public virtual Phone Phone { get; set; }
        public virtual Address Address { get; set; }

        public virtual ICollection<StudentCustomFieldValue> StudentCustomFieldValues { get; set; }
    }
}
