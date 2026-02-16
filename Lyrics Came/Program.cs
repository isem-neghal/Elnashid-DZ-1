using System;
using System.Text;
using System.Threading;
using Spectre.Console;

namespace Lyrics_Calme
{
    class Cod
    {



        static void Main()
        {
            Console.ReadLine();

            WriteLyrics();
        }

        static void WriteLyrics()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.CursorVisible = false;
            Console.Clear();

            string[] Lyrics = {
                "\n        ت ﺎﻘﺣﺎﻤﻟﺍ ت ﻻﺯﺎﻨﻠﺑ ﺎﻤﺳﻗ",
                "\n      ت اﺮﻫﺎﻃلﺍ ت ﺎﻴﻛﺍﺰﻟﺍ ءﺎﻣﺪﻟﺍﻭ\t\t\t\t\t\t\t\t\t\t\t\t\t\t", 
                 "\n        ت ﺎﻘﺣﺎﻤﻟﺍ ت ﻻﺯﺎﻨﻠﺑ ﺎﻤﺳﻗ",

                "\n      ت اﺮﻫﺎﻃلﺍ ت ﺎﻴﻛﺍﺰﻟﺍ ءﺎﻣﺪﻟﺍﻭ\t\t\t\t\t\t\t\t\t\t\t\t\t\t",
                "\n      ت ﺎﻘﻓﺎﺨﻟﺍ ت ﺎﻌﻣﻼﻟﺍ دﻮﻨﺒﻟﺍﻭ",

               "\n ت ﺎﻘﻫﺎﺸﻟﺍ ت ﺎﺨﻣﺎﺸﻟﺍ لﺎﺒﺠﻟﺍ ﻲﻓ\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t",

                "\nت ﺎﻤﻣ وﺃ ةﺎﻴﺤﻓ ﺎﻧﺮﺛ ﻦﺤﻧ",

                "\nﺮﺋﺍﺰﺠﻟﺍ ﺎﻴﺤﺗ نﺃ مﺰﻋلﺍ ﺎﻧﺪﻘﻋﻭ\t\t\t\t\t\t\t\t\t\t\t\t\t\t",

                "            اﻭﺪﻬﺷ ﺎﻓ .. اﻭﺪﻬﺷ ﺎﻓ .. اﻭﺪﻬﺷ ﺎﻓ"
            };

            double[] delays = { 0.3, 0.3, 0.3, 0.3, 0.3, 0.1, 0.01, 0.01};

            
            string title = "               ي ﺮﺋﺍﺶﺠﻟﺍ ﻲﻨﻃ ﻮﻟﺍ ﺪﻴﺸﻨﻟﺍ               ";
            int titlePos = Console.WindowWidth - title.Length - 5;
            if (titlePos < 0) titlePos = 0;

            Console.SetCursorPosition(titlePos, Console.CursorTop);
            AnsiConsole.MarkupLine($"[bold yellow on blue]{title}[/]");
            Console.WriteLine();

            Thread.Sleep(2000);

            for (int i = 0; i < Lyrics.Length; i++)
            {
                string line = Lyrics[i];
                int lineLength = line.Length;

                int startPos = Console.WindowWidth - lineLength - 5;
                if (startPos < 0) startPos = 0;

               
                Thread.Sleep(1000);

                Console.SetCursorPosition(startPos + lineLength - 1, Console.CursorTop);

                
                for (int j = lineLength - 1; j >= 0; j--)
                {
                    Console.SetCursorPosition(startPos + j, Console.CursorTop);
                    Console.Write(line[j]);
                    Thread.Sleep(85);
                }

                Console.WriteLine();
                //Thread.Sleep((int)(delays[i] = 3000));
                double seconds = (i < delays.Length) ? delays[i] : delays[delays.Length - 1];
                int milliseconds = (int)(seconds * 1000);
                Thread.Sleep(milliseconds);

            }

            Console.WriteLine();
            Console.CursorVisible = true;

            
            Console.ReadKey();
        }
    }
}