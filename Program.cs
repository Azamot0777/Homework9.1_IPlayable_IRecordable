using System;

namespace Homework9_1_IPlayable_IRecordable
{

    interface IPlayable
    {
        public void Play();
        public void Pause();
        public void Stop();

    }
    interface IRecordable
    {
        public void Record();
        public void Pause();
        public void Stop();
    }

    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            System.Console.WriteLine("Play");
        }
        public void Record()
        {
            System.Console.WriteLine("Record");
        }
        public void Pause()
        {
            System.Console.WriteLine("Pause");
        }
        public void Stop()
        {
            System.Console.WriteLine("Stop");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Player cust = new Player();
            System.Console.WriteLine("Action of program");
            cust.Play();
            cust.Record();
            cust.Pause();
            cust.Stop();
        }
    }
}
