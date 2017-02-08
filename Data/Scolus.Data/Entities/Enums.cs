using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scolus.Data.Entities
{
    public enum SchoolType
    {
        Public = 1,
        Private = 2
    }

    public enum PhoneType
    {
        Mobile = 1,
        Telephone = 2,
        Fax = 3
    }

    public enum CustomFieldType
    {
        TextField = 1,
        TextArea = 2,
        DropDown = 3,
        RadioButton = 4,
        CheckBox = 5
    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }
}
