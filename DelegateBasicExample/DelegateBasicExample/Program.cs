// See https://aka.ms/new-console-template for more information

namespace DelegateBasicExample
{
    delegate void LogDel(string text);

    class Program
    {
        delegate void LogDel(string text);


        static void Main(string[] args)
        {
            Log log = new();
            LogDel LogTextToScreenDel, LogTextToFileDel;

            LogTextToScreenDel = new(log.LogTextToScreen);

            LogTextToFileDel = new(log.LogTextToFile);
            LogDel multiLogDel = LogTextToScreenDel + LogTextToFileDel;

            Console.WriteLine("Please enter your name");

            var name = Console.ReadLine() ?? "";

            LogText(multiLogDel, name);

            Console.ReadKey();
        }

        static void LogText(LogDel logDel, string text)
        {
            logDel(text);
        }

        public class Log
        {
            public void LogTextToScreen(string text)
            {
                Console.WriteLine($"{DateTime.Now}: {text}");


            }

            public void LogTextToFile(string text)
            {
                using StreamWriter sw = new(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"));
                sw.WriteLine($"{DateTime.Now}: {text}");
            }

        }



    }
}