using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4__Abstract_classes_and_Interfaces_
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXTHandler.Open();");
        }

        public override void Create()
        {
            Console.WriteLine("TXTHandler.Create();");
        }

        public override void Change()
        {
            Console.WriteLine("TXTHandler.Change();");
        }

        public override void Save()
        {
            Console.WriteLine("TXTHandler.Save();");
        }
    }
}
