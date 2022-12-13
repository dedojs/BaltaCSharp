// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Menu();

static void Menu()
{
    Console.Clear();
    System.Console.WriteLine("Bem vindo ao nosso Text Editor");
    System.Console.WriteLine("O que deseja fazer?");
    System.Console.WriteLine("1 - Abrir Arquivo");
    System.Console.WriteLine("2 - Criar Arquivo");
    System.Console.WriteLine("0 - Sair");

    short option = short.Parse(Console.ReadLine());

    switch (option)
    {
        case 0:
            System.Console.WriteLine("Volte Sempre!");
            System.Environment.Exit(0);
            break;
        case 1:
            Abrir();
            break;
        case 2:
            Editar();
            break;
        default:
            Menu();
            break;
    }
}

static void Abrir()
{
    System.Console.Clear();
    System.Console.WriteLine("Qual nome do arquivo?");
    string fileOption = Console.ReadLine();
    string path = @$"E:\BaltaIOC#\BaltaCSharp\FundamentosCSharp\TextEditor\Textos\{fileOption}.txt";

    using (var file = new StreamReader(path))
    {
        string text = file.ReadToEnd();
        System.Console.WriteLine(text);
    }
    System.Console.WriteLine("");
    Console.ReadLine();
    Menu();

}

static void Editar()
{
    Console.Clear();
    System.Console.WriteLine("Digite seu texto abaixo:");
    System.Console.WriteLine("Para salvar o texto, aperte a tecla ESC");
    System.Console.WriteLine("------------------------");
    string text = "";

    do
    {
        text += Console.ReadLine();
        text += Environment.NewLine;
    }
    while (Console.ReadKey().Key != ConsoleKey.Escape);
    Salvar(text);

}

static void Salvar(string text)
{
    Console.Clear();
    System.Console.WriteLine("DDigite o nome para o Novo arquivo: ");
    string name = Console.ReadLine();
    var path = @$"E:\BaltaIOC#\BaltaCSharp\FundamentosCSharp\TextEditor\Textos\{name}.txt";
    using (var file = new StreamWriter(path)) //Cria, abre e fecha arquivos
    {
        file.Write(text);
    }
    System.Console.WriteLine($"Arquivo {path} salvo com sucesso!");
    Thread.Sleep(2000);
    Menu();
}
