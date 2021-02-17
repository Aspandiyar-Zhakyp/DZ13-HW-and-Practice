using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateHW
{
    public delegate void ButtonActionDelegate<T>(params T[] value);
    public class Button
    {
        public char BorderSymbol { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string Text { get; set; }
        public ConsoleColor BackgroundColor { get; set; }
        public ConsoleColor BorderColor { get; set; }
        public ButtonActionDelegate<string> Action { get; set; }
        public void ShowButton()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (j == 0 || i == 0 || j == Width - 1 || i == Height - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.BackgroundColor = BorderColor;
                        Console.Write(BorderSymbol);
                    }
                    else
                    {
                        Console.BackgroundColor = BackgroundColor;
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.SetCursorPosition(Width / 5, Height / 3);
            Console.Write(Text);
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void PressTheButton()
        {
            Action?.Invoke("==(*)", "You wrote it seriously, you couldn't think of anything else", "(*)==");
            Console.ReadLine();
        }
    }
}
