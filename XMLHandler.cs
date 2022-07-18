using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4__Abstract_classes_and_Interfaces_
{
    class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XMLHandler.Open();");
        }

        public override void Create()
        {
            Console.WriteLine("XMLHandler.Create();");
        }

        public override void Change()
        {
            Console.WriteLine("XMLHandler.Change();");
        }

        public override void Save()
        {
            Console.WriteLine("XMLHandler.Save();");
        }
    }
}
