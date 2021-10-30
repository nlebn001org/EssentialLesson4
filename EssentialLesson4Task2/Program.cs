using System;

namespace EssentialLesson4Task2
{

    //    Задание 2
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создайте класс AbstractHandler.
    //В теле класса создать методы void Open(), void Create(), void Chenge(), void Save().
    //Создать производные классы XMLHandler, TXTHandler, DOCHandler от базового класса AbstractHandler.
    //Написать программу, которая будет выполнять определение документа и для каждого формата должны быть методы открытия, создания, редактирования, сохранения определенного формата документа.
    
    class Program
    {

        static string str;
        static AbstractHandler abs;
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Input fromat type.");
                str =  Console.ReadLine();

                switch (str)
                {
                    case "doc":
                        {
                            abs = new DOCHandler();
                            abs.Create();
                            abs.Open();
                            abs.Change();
                            abs.Save();
                            break;
                        }

                    case "txt":
                        {
                            abs = new TXTHandler();
                            abs.Create();
                            abs.Open();
                            abs.Change();
                            abs.Save();
                            break;
                        }

                    case "xml":
                        {
                            abs = new XMLHandler();
                            abs.Create();
                            abs.Open();
                            abs.Change();
                            abs.Save();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine($"'{str}' format is not acceptable.\n");
                            break;
                        }

                }


            }
            

        }
    }
}
