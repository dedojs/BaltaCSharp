# Dicas C# .NET

## Converção explícita
``` 
int inteiro = 100;
double inteiroDouble = (double)inteiro;
```

## Parse
``` 
O Parse só aceita se for uma string.
int inteiro = int.Parse("100");

```

## Convert
``` 
Para conversão é mais indicado o Convert, por ser mais preciso
int inteiro2 = Convert.ToInt32("100");

```

## Struct
``` 
São tipos de valor. Servem para estruturar os dados

struct Product
{
    public int Id;
    public double Price;
    public string Title;

    public Product(int id, double price, string title)
    {
        Id = id;
        Price = price;
        Title = title;
    }

    public double PriceInDolar(double dolar)
    {
        return Price * dolar;
    }

    public override string ToString()
    {
        return $"{Id} - {Title} - R$ {Price} ";
    }

}

```

## Enums
``` 
Utilizado para substituir valores pré definidos

enum EEstadoCivil
{
    Solteiro = 1,
    Casado = 2,
    Divorciado = 3,
}
```

# Strings

## Guids
``` 
// Guids
// Gerando um guid
var id = Guid.NewGuid();
// Gerando um id menor através de um guid
var id2 = Guid.NewGuid().ToString().Substring(0, 8);

System.Console.WriteLine(id);
System.Console.WriteLine(id2);
```

## Comparando Strings
``` 
// string.Contains()
var texto = "Testando o teste do testador";
    System.Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase));
```

## StartsWith / EndsWith
``` 
// string.StartsWith()
//Começa com?
var texto = "Testando o teste do testador";
System.Console.WriteLine(texto.StartsWith("Testando"));

// string.EndsWith()
// Termina com?
var texto = "Testando o teste do testador";
System.Console.WriteLine(texto.EndsWith("testador"));
```

## Equals
``` 
// string.Equals()
// Verificar igualdade entre as strings
var texto = "Testando";
System.Console.WriteLine(texto.Equals("Testando"));

```

## IndexOf
``` 
// string.IndexOf()
var texto = "Testando";
System.Console.WriteLine(texto.IndexOf('a'));
texto.LastIndexOf();

```

## Outros métodos
``` 
string.ToLower();
string.ToUpper();
string.Insert(5, "aqui"); // indice, informação
string.remove(0, 5); // inicio , quantidade
string.Length;
```

## Manipulando strings
``` 
string.Replace("Este", "isto"); //troca este por isto
string.Split(","); // divide de acordo ao especificado
string.Substring(2, 5); //inicio, fim, seleciona a parte informada
string.Trim(); // Remove espaços no inicio e fim
```

