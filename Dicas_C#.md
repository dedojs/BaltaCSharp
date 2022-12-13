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