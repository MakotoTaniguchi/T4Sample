using DtoGenerator;
using DtoGenerator.Entitys;
using DtoGenerator.TextTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            TsInterfaceEntity entity = new TsInterfaceEntity
            {
                ClassName = "test",
                PropertyInfos = new List<PropertyInfo> {
                    new PropertyInfo { PropertyName = "Isasync", TypeName = "boolean" },
                    new PropertyInfo { PropertyName = "TimeOut", TypeName = "number" },
                    new PropertyInfo { PropertyName = "BeforeRequest", TypeName = "any" },
                }
            };

            var generator = new DtoGeneratorManager("sample.ts");
            generator.InterfaceGenerate(entity);
        }
    }
}
