using DtoGenerator.Entitys;
using DtoGenerator.TextTemplates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoGenerator
{
    public class DtoGeneratorManager
    {
        private string FileName
        {
            get;
            set;
        }

        public DtoGeneratorManager(string fileName)
        {
            FileName = fileName;
        }

        public bool InterfaceGenerate(TsInterfaceEntity entity)
        {
            var tsInterface = new TsInterface(entity);

            var pageContent = tsInterface.TransformText();

            File.WriteAllText(FileName, pageContent);
            return true;
        }
    }
}
