// Signed integral Types
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Unsigned integral types
Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Evaluate floating-point types
Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// Because floating-point types can hold large numbers with a lot of precision,
// their values can be represented using "E notation", which is a form of
// scientific notation that means "times ten raised to the power of." So, a
// value like 5E+2 would be the value 500 because it's the equivalent of 5 *
// 10^2, or 5 * 10 * 10.

// TryParse()
// Ele tenta analisar uma cadeia de caracteres sobre o tipo de dados numérico fornecido.
// Se for bem-sucedido, ele armazenará o valor convertido em um parâmetro out.
// Ele retorna um bool para indicar se a ação foi bem-sucedida ou falhou.

//  parâmetro out? Os métodos podem retornar um valor ou retornar "nulo", o que
// significa que eles não retornam nenhum valor. Os métodos também podem
// retornar valores por meio de parâmetros out, definidos como um parâmetro de
// entrada, porém incluem a palavra-chave out.
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
// O método int.TryParse() retornará true se ele tiver convertido com êxito
// nossa string de variável value em um int; caso contrário, ele retornará
// false. Portanto, envolva a instrução em uma instrução if e execute a lógica
// de decisão de modo adequado.

// Sort()
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Reverse()
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Clear()
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// Resize()
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// ToCharArray()
string value = "abc123";
char[] valueArray = value.ToCharArray();

// Inverter e combinar a matriz char em uma nova cadeia de caracteres
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);

// O que é a palavra-chave new? Como a classe System.String está relacionada ao
// tipo de dados string em C#? O que é um construtor? Todas excelentes perguntas
// que não estão no escopo deste módulo. Recomendamos que você continue
// aprendendo sobre a biblioteca de classes .NET, bem como classes e objetos em
// C# para entender por completo o que está acontecendo nos bastidores com essa
// expressão de código. Por enquanto, recomendamos que você use um mecanismo de
// pesquisa e o Microsoft Docs para encontrar bons exemplos que possam ser
// usados em situações como essa, nas quais você sabe que deseja executar uma
// conversão, mas não tem certeza de como fazer isso usando o C#.


// Formatação Composta A formatação composta usa espaços reservados numerados
// dentro de uma cadeia de caracteres. Em tempo de execução, tudo dentro das
// chaves será resolvido para um valor que também é passado com base em sua
// posição.
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);
// A cadeia de caracteres literal "{0} {1}!" forma um modelo, partes das quais serão substituídas em tempo de execução.
// O token {0} é substituído pelo primeiro argumento depois do modelo da cadeia de caracteres; em outras palavras, o valor da variável first.
// O token {1} é substituído pelo segundo argumento depois do modelo da cadeia de caracteres; em outras palavras, o valor da variável second.
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second);
Console.WriteLine("{0} {0} {0}!", first, second);

// interpolação de cadeia de caracteres
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

// Moeda de formatação A formatação composta e a interpolação de cadeia de
// caracteres podem ser usadas para formatar valores para exibição considerando
// uma linguagem e cultura específicas. No exemplo a seguir, o especificador de
// formato de moeda :C é usado para apresentar as variáveis price e discount
// como moeda.
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// Formatar números Ao trabalhar com os dados numéricos, convém formatar o
// número para facilitar a leitura incluindo vírgulas para delinear milhares,
// milhões, bilhões e assim por diante.
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");

// Formatar percentuais
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");