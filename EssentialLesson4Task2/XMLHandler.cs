using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialLesson4Task2
{
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("XMLHandler method Change()");
        }

        public override void Create()
        {
            Console.WriteLine("XMLHandler method Create()");
        }

        public override void Open()
        {
            Console.WriteLine("XMLHandler method Open()");
        }

        public override void Save()
        {
            Console.WriteLine("XMLHandler method Save()");
        }
    }
}
