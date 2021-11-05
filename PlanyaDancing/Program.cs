using System;
using System.Threading;

namespace PlanyaDancing
{
    class Program
    {
        static void Main(string[] args)
        {
            Frames instance = new Frames();

            var frame = instance.frames;

            int consoleWidth = 45;
            int consoleHeight = 50;

            int speedFrame = 80;
            int countFrames = instance.frames.Length;

#pragma warning disable CA1416 // Проверка совместимости платформы
            Console.SetWindowSize(consoleWidth, consoleHeight);

            Animation(countFrames, frame, speedFrame);
        }
        private static void Animation(int countFrames, string[] frame, int speedFrame)
        {
            while (true)
            {
                int n = countFrames;
                for (int i = 0; i < n; i++)
                {
                    Console.Write("\r" + frame[i]);
                    Thread.Sleep(speedFrame);
                }
                n = 0;
                for (int i = countFrames - 1; i > n; i--, n++)
                {
                    Console.Write("\r" + frame[i]);
                    Thread.Sleep(speedFrame);
                }
            }
        }
    }
}
