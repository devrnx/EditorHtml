using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do
            {
                file.AppendLine(Console.ReadLine());
                file.AppendLine(Environment.NewLine);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Viewer.Show(file.ToString());
        }
    }
}