using Scolus.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolus.Data.Interface
{
    public interface ISchoolService
    {
        Response Create(School entity);
        Response Update(School entity);
        Response Delete(int entityId);
    }
}
