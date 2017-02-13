using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.School.Interface
{
    interface IValidationMessage
    {
        List<string> ErrorMessage { get; }
        bool IsModelValid { get; }
        void Validate();
    }
}
