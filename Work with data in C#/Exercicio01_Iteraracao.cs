// Iterar por meio de cada valor em uma cadeia de caracteres de valores.

// Comece com a seguinte linha de código.
// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// Adicione todo o código necessário para implementar as seguintes regras de negócio:

// Regras de negócio:

// Regra 1: se o valor for alfanumérico, concatene-o para formar uma mensagem

// Regra 2: se o valor for numérico, adicione-o ao total

// Regra 3: verifique se o resultado corresponde à seguinte saída:
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        total += number;
    } else
    {
        message += value;
    }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");