using Domain.School.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Entities = Scolus.Data.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scolus.Data.Entities;

namespace Domain.School.DTO
{
    public class School : IAudit, IValidationMessage, IEntityMapper<Entities.School>
    {
        public School()
        {
            this.ErrorMessage = new List<string>();
            this.IsModelValid = false;
        }

        public int SchoolId { get; set; }

        string _name;
        public string Name
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_name))
                    this.ErrorMessage.Add("Name is required");

                return _name;
            }
            set { _name = value; }
        }

        string _description;
        public string Description
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_description))
                    this.ErrorMessage.Add("Description is required");

                return _description;
            }
            set { _description = value; }
        }

        public SchoolType Type { get; set; }

        public string ReferenceId { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

        public List<string> ErrorMessage { get; private set; }

        public bool IsModelValid { get; private set; }

        public void Validate()
        {
            JsonConvert.SerializeObject(this);
        }

        public Entities.School MapToEntity()
        {
            var entity = new Entities.School()
            {
                SchoolId = this.SchoolId,
                Name = this.Name,
                Description = this.Description,
                Type = (Entities.SchoolType)this.Type,
                ReferenceId = this.ReferenceId,
                CreatedBy = this.CreatedBy,
                CreatedOn = this.CreatedOn,
                UpdatedBy = this.UpdatedBy,
                UpdatedOn = this.UpdatedOn
            };
            return entity;
        }
    }
}
