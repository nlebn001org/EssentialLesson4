﻿using System;

namespace EssentialLesson4Task1
{
    class Footer : InfoClass
    {

        string content;

        public string Content
        {
            private get
            {
                if (content != null)
                    return content;
                else
                    return "Нижний колонтитул отсутствует.";
            }
            set
            {
                content = value;
            }
        }

        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
