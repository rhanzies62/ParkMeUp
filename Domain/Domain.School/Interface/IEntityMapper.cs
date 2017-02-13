using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.School.Interface
{
    interface IEntityMapper<T>
    {
        T MapToEntity();
    }
}
