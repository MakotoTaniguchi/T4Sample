using DtoGenerator.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoGenerator.TextTemplates
{
    public partial class TsInterface : TsInterfaceBase
    {
        private TsInterfaceEntity Entity
        {
            get;
            set;
        }
        
        public TsInterface(TsInterfaceEntity entity): base()
        {
            Entity = entity;
        }
    }
}
