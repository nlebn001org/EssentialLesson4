using System;

namespace EssentialLesson4Task3
{
    class Player : IPlayable, IRecodable
    {

        public void Record()
        {
            Console.WriteLine("Recording of Player object in progress.");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Recording of Player object is paused.");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Recording of Player object is stopped.");
        }


        public void Play()
        {
            Console.WriteLine("Sound of Player object is playing.");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Sound of Player object is paused.");
        }


        void IPlayable.Stop()
        {
            Console.WriteLine("Sound of Player object is stopped.");
        }
    }
}
