using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.School.DTO
{
    public class Response
    {
        public Response()
        {
            this.Success = false;
            this.Messages = new List<string>();
        }
        public bool Success { get; set; }
        public int ReferenceID { get; set; }
        public List<string> Messages { get; set; }
    }
}
