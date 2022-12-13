using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Menu();

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                System.Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            System.Console.WriteLine("StopWatch Finalizado!");
            Thread.Sleep(1000);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            System.Console.WriteLine("Ready....");
            Thread.Sleep(500);
            System.Console.WriteLine("Set....");
            Thread.Sleep(500);
            System.Console.WriteLine("Go....");
            Thread.Sleep(500);
            Start(time);
        }

        static void Menu()
        {
            Console.Clear();
            System.Console.WriteLine("Bem vindo ao StopWatch");
            System.Console.WriteLine("S = Segundo => 10s = 10 Segundos");
            System.Console.WriteLine("M = Minuto => 1m = 1 Minuto");
            System.Console.WriteLine("0 = Sair");
            System.Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            if (type == 's')
            {
                PreStart(time);
            }
            else if (type == 'm')
            {
                PreStart(time * 60);
            }
            else if (time == 0)
            {
                System.Console.WriteLine("Volte sempre!");
                System.Environment.Exit(0);
            }
            else if (type != 's' || type == 'm')
            {
                System.Console.WriteLine("Informação incorreta");
                Thread.Sleep(1000);
                Menu();
            }

        }

    }

}