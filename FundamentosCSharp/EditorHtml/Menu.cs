using System;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            DrawScreen();
            WriteOptions();
            var option = short.Parse(Console.ReadLine());
            HandleMenuOptions(option);

        }

        public static void DrawLine(string character, int lines)
        {
            System.Console.Write(character);
            for (int i = 0; i <= lines; i++)
            {
                System.Console.Write("-");
            }
            System.Console.Write(character);
            System.Console.Write("\n");
        }

        public static void DrawScreen()
        {
            DrawLine("+", 30);

            for (int lines = 0; lines <= 10; lines++)
            {
                System.Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("|");
                System.Console.Write("\n");
            }

            DrawLine("+", 30);
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(2, 1);
            System.Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(1, 2);
            DrawLine("-", 28);
            Console.SetCursorPosition(2, 3);
            System.Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(2, 5);
            System.Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(2, 6);
            System.Console.WriteLine("2 - Abrir");
             Console.SetCursorPosition(2, 7);
            System.Console.WriteLine("0 - Sair");
             Console.SetCursorPosition(2, 9);
            System.Console.Write("Opção: ");
        }
    
        public static void HandleMenuOptions(short option)
        {
            switch(option)
            {
                case 1:
                    System.Console.WriteLine("Editor");
                    Editor.Show();
                    break;
                case 2: System.Console.WriteLine("View"); break;
                case 0:
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default: Show(); break;

            }
        }
    }
}