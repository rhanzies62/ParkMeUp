using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.School.Interface
{
    public interface ISchoolLogic
    {
        DTO.Response Register(DTO.School entity,string username);
        DTO.Response UpdateInfo(DTO.School entity,string username);
    }
}
