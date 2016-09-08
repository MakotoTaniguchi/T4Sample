using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoGenerator.Entitys
{
    public partial class TsInterfaceEntity
    {
        public string ClassName
        {
            get;
            set;
        }

        public List<PropertyInfo> PropertyInfos
        {
            get;
            set;
        }
    }

    public class PropertyInfo
    {
        public string TypeName
        {
            get;
            set;
        }

        public string PropertyName
        {
            get;
            set;
        }
    }
}
