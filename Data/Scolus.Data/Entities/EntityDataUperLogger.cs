using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolus.Data.Entities
{
    public class EntityDataUperLogger
    {
        [Key]
        public int Id { get; set; }
        public string Data { get; set; }
        public string TableName { get; set; }
        public CUD Type { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
