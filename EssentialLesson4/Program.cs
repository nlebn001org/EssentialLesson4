using EssentialLesson4Task1;
using System;
using System.Text;

namespace EssentialLesson4
{

    //    Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется: Изменить 12 пример первого урока(работа с документом) и создать общий абстрактный класс для всех частей документа.

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Title title = new Title();
            title.Content = "Контракт";

            Body body = new Body();
            body.Content = "Тело контракта...";

            Footer footer = new Footer();
            footer.Content = "Директор: Иванов И.И.";

            Document document = new Document(title, body, footer);
            document.Show();

            // Delay.
            Console.ReadKey();
        }
    }
}
