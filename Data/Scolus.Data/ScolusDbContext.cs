using Scolus.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolus.Data
{
    public class ScolusDbContext : DbContext
    {
        //TODO : Connection string
        public ScolusDbContext() : base("ScolusEntities")
        {

        }

        public DbSet<EntityDataUperLogger> EntityDataUperLoggers { get; set; }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<EntityLookUp> EntityLookUps { get; set; }

        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolCustomFieldSetUp> SchoolCustomFieldSetUp { get; set; }

        public DbSet<CustomField> CustomFields { get; set; }
        public DbSet<CustomFieldOption> CustomFieldOptions { get; set; }

        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<FacultyCustomFieldSetUp> FacultyCustomFieldSetUps { get; set; }
        public DbSet<FacultyCustomFieldValue> FacultyCustomFieldValues { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCustomFieldSetUp> StudentCustomFieldSetUps { get; set; }
        public DbSet<StudentCustomFieldValue> StudentCustomFieldValues { get; set; }
    }
}
