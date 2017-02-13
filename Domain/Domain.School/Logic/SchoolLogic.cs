using Domain.School.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.School.DTO;
using Scolus.Data.Interface;
using Common.Utility;
using DataService = Scolus.Data.Service;

namespace Domain.School.Logic
{
    public class SchoolLogic : ISchoolLogic
    {
        private readonly ISchoolService schoolService;

        public SchoolLogic()
        {
            this.schoolService = new DataService.SchoolService();
        }

        public Response Register(DTO.School entity,string username)
        {
            var response = new Response();
            entity.Validate();
            if (entity.IsModelValid)
            {
                entity.ReferenceId = HelperMethod.GenerateTimestamp();
                entity.CreatedBy = username;
                entity.UpdatedBy = username;

                var serviceResponse = schoolService.Create(entity.MapToEntity());
                response.Messages = serviceResponse.Messages;
                response.ReferenceID = serviceResponse.ReferenceID;
                response.Success = serviceResponse.Success;
            }else
            {
                response.Messages = entity.ErrorMessage;
            }

            return response;
        }

        public Response UpdateInfo(DTO.School entity,string username)
        {
            var response = new Response();
            entity.Validate();
            if (entity.IsModelValid)
            {
                entity.UpdatedBy = username;
                var serviceResponse = schoolService.Update(entity.MapToEntity());
                response.Messages = serviceResponse.Messages;
                response.ReferenceID = serviceResponse.ReferenceID;
                response.Success = serviceResponse.Success;
            }
            else
            {
                response.Messages = entity.ErrorMessage;
            }

            return response;
        }
    }
}
