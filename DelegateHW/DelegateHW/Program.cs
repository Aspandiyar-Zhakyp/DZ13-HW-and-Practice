using System;
using System.Collections.Generic;

namespace DelegateHW
{
    class Program
    {
        static void Main(string[] args)
        {
            var button = new Button
            {
                BorderSymbol = '*',
                Text = "Write something",
                Width = 20,
                Height = 10,
                BackgroundColor = ConsoleColor.Black,
                BorderColor = ConsoleColor.Yellow,
                Action = new ButtonActionDelegate<string>(PrintStrings)
            };
            button.ShowButton();
            button.PressTheButton();
        }
        private static void PrintStrings(string[] values)
        {
            foreach (var str in values)
            {
                Console.Write(str);
            }
        }
    }
}
