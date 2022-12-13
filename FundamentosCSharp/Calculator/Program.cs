// See https://aka.ms/new-console-template for more information

Menu();

static void Soma()
{
    Console.Clear();

    System.Console.WriteLine("Soma");

    System.Console.WriteLine("Primeiro Valor: ");
    double valor1 = double.Parse(Console.ReadLine());

    System.Console.WriteLine("Segundo Valor: ");
    double valor2 = double.Parse(Console.ReadLine());

    System.Console.WriteLine("");

    System.Console.WriteLine($"O resultado da soma foi {valor1 + valor2}");

    Console.ReadKey();
}

static void Subtracao()
{
    Console.Clear();

    System.Console.WriteLine("Subtração");

    System.Console.WriteLine("Primeiro Valor: ");
    double valor1 = double.Parse(Console.ReadLine());

    System.Console.WriteLine("Segundo Valor: ");
    double valor2 = double.Parse(Console.ReadLine());

    System.Console.WriteLine("");

    System.Console.WriteLine($"O resultado da subtração foi {valor1 - valor2}");

    Console.ReadKey();
}

static void Divisao()
{
    Console.Clear();

    System.Console.WriteLine("Divisão");

    System.Console.WriteLine("Primeiro Valor: ");
    double valor1 = double.Parse(Console.ReadLine());

    System.Console.WriteLine("Segundo Valor: ");
    double valor2 = double.Parse(Console.ReadLine());

    System.Console.WriteLine("");

    System.Console.WriteLine($"O resultado da divisão foi {valor1 / valor2}");

    Console.ReadKey();
}

static void Multiplicacao()
{
    Console.Clear();

    System.Console.WriteLine("Multiplicação");

    System.Console.WriteLine("Primeiro Valor: ");
    double valor1 = double.Parse(Console.ReadLine());

    System.Console.WriteLine("Segundo Valor: ");
    double valor2 = double.Parse(Console.ReadLine());

    System.Console.WriteLine("");

    System.Console.WriteLine($"O resultado da multiplicação foi {valor1 * valor2}");

    Console.ReadKey();
}

static void Menu()
{
    Console.Clear();
    System.Console.WriteLine("Bem vindo a Calculadora do Balta");
    System.Console.WriteLine("Qual operação deseja fazer?");
    System.Console.WriteLine("1 - Soma");
    System.Console.WriteLine("2 - Subtração");
    System.Console.WriteLine("3 - Divisão");
    System.Console.WriteLine("4 - Multiplicação");
    System.Console.WriteLine("5 - Sair");

    System.Console.WriteLine("-------------------");
    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case (1):
            Soma();
            Menu();
            break;
        case (2):
            Subtracao();
            Menu();
            break;
        case (3):
            Divisao();
            Menu();
            break;
        case (4):
            Multiplicacao();
            Menu();
            break;
        case (5):
            System.Console.WriteLine("Obrigado! Volte sempre");
            System.Environment.Exit(0);
            break;
        default:
            System.Console.WriteLine("Opção inválida! Click aqui para retornar a calculadora.");
            Console.ReadKey();
            Menu();
            break;
    }
}