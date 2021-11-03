﻿using System;

namespace EssentialLesson4Task2
{
    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("DOCHandler method Change()");
        }

        public override void Create()
        {
            Console.WriteLine("DOCHandler method Create()");
        }

        public override void Open()
        {
            Console.WriteLine("DOCHandler method Open()");
        }

        public override void Save()
        {
            Console.WriteLine("DOCHandler method Save()");
        }
    }
}
