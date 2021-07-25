using System;
using System.Threading;
/*
Картинка скачет только первые ~10 секунд (до тех пор, пока ползунок не опуститься полностью вниз)
После картинка станет плавной
Связано это с тем, что набор элементов в Frames.cs разного размера
p.s. да, мне лень это фиксить.
*/
namespace PlanyaDancing
{
    class Program
    {
        static void Main(string[] args)
        {
            Frames instance = new Frames();

            int consoleWidth = 45;
            int consoleHeight = 50;

#pragma warning disable CA1416 // Проверка совместимости платформы
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
