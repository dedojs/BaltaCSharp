using System;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            System.Console.WriteLine("Modo de Visualização");
            System.Console.WriteLine("-----------");
            Replace(text);
            System.Console.WriteLine("-----------");
            Console.ReadKey();
            Menu.Show();
        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    System.Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (
                                (words[i].LastIndexOf('<') -1) - words[i].IndexOf('>')
                            )
                        )
                    );
                        System.Console.Write(" ");
                }
                else {
                    System.Console.Write(words[i]);
                    System.Console.Write(" ");
                }
            }
        }
    }
}