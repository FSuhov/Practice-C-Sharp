using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Создайте 2 интерфейса IPlayable и IRecodable. В каждом из интерфейсов создайте по 3 метода void Play() / void Pause() / void Stop() и void Record() / void Pause() / void Stop() соответственно.
Создайте производный класс Player от базовых интерфейсов IPlayable и IRecodable.
Написать программу, которая выполняет проигрывание и запись.
*/
namespace _02Player
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 - PLAY");
                Console.WriteLine("2 - PAUSE PLAY");
                Console.WriteLine("3 - STOP PLAY");
                Console.WriteLine("4 - START RECORD");
                Console.WriteLine("5 - PAUSE RECORD");
                Console.WriteLine("6 - STOP RECORD");
            }
        }
    }

    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Player : IPlayable, IRecordable
    {
        bool playIsOn = false;
        bool playIsPaused = false;
        bool recordIsOn = false;
        bool recordIsPaused = false;

        void IPlayable.Pause()
        {
            if (recordIsOn) { Console.WriteLine("You have to stop recording"); return; }
            if (playIsOn && !playIsPaused) { Console.WriteLine("La-la-la-la-la-la"); return; }
            if (playIsPaused) { Console.WriteLine("Already paused"); }
        }

        void IRecordable.Pause()
        {
            if (recordIsOn) { Console.WriteLine("You have to stop playing"); return; }
            if (playIsOn && !playIsPaused) { Console.WriteLine("DONE"); return; }
            if (playIsPaused) { Console.WriteLine("Already paused"); }
        }

        void IPlayable.Play()
        {
            if (!playIsOn) { Console.WriteLine("La-la-la-la-la-la");return; }
            
        }

        void IRecordable.Record()
        {
            Console.WriteLine("Recording has been started, please start singing");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Playing stopped");
        }

        void IRecordable.Stop()
        {
            Console.WriteLine("Record is being saving");
        }
    }
}
