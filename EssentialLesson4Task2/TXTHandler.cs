using System;

namespace EssentialLesson4Task2
{
    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("TXTHandler method Change()");
        }

        public override void Create()
        {
            Console.WriteLine("TXTHandler method Create()");
        }

        public override void Open()
        {
            Console.WriteLine("TXTHandler method Open()");
        }

        public override void Save()
        {
            Console.WriteLine("TXTHandler method Save()");
        }
    }
}
