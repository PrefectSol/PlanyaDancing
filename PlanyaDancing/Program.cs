using System;
using System.Threading;

namespace PlanyaDancing
{
    class Program
    {
        static void Main(string[] args)
        {
            Frames instance = new Frames();

            int consoleWidth = 45;
            int consoleHeight = 50;

#pragma warning disable CA1416 // Checking platform compatibility
            Console.SetWindowSize(width: consoleWidth,
                                  height: consoleHeight);
            int speedFrame = 80;
            var frame = instance.frames;

            while (true)
            {
                int n = 11;
                for (int i = 0; i < n; i++) 
                {
                    Console.Write(frame[i]);
                    Thread.Sleep(speedFrame);
                }
                n = 0;
                for (int i = 10; i > n; i--) 
                {
                    Console.Write(frame[i]);
                    Thread.Sleep(speedFrame);
                    n++;
                }
            }
        }
    }
}
