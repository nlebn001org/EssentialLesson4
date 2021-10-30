using System;

namespace EssentialLesson4Task3
{

    //    Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется:
    //Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
    //Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
    //Написать программу, которая выполняет проигрывание и запись.
    class Program
    {

        static IPlayable play;
        static IRecodable recrod;

        static void Main(string[] args)
        {

            play = new Player();
            recrod = new Player();

            recrod.Record();
            recrod.Pause();
            recrod.Stop();
            Console.WriteLine();
            play.Play();
            play.Pause();
            play.Stop();

        }
    }
}
