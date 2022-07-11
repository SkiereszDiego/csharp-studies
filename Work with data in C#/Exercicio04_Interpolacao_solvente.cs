// queremos imprimir um recibo da venda de um solvente químico usado em ambientes
// industriais. Embora nossas balanças meçam em microgramas, estabelecemos o preço
// de cada venda em miligramas (um milésimo de um grama). Para imprimir o recibo,
// provavelmente precisaríamos combinar dados de diferentes tipos, incluindo
// valores fracionários, moeda e percentuais de maneiras precisas.

int invoiceNumber = 1201;
decimal productMeasurement = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Measurement: {productMeasurement:N3} mg");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Due: {total:C}");

// Métodos que adicionam espaços em branco para fins de formatação (PadLeft(),
// PadRight())

// Métodos que comparam duas cadeias de caracteres ou facilitam a comparação
// (Trim(), TrimStart(), TrimEnd(), GetHashcode(), a propriedade Length)
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12));
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

// Métodos que ajudam a determinar o que há dentro de uma cadeia de caracteres
// ou até mesmo recuperar apenas uma parte da cadeia de caracteres (Contains(),
// StartsWith(), EndsWith(), Substring())

// Métodos que alteram o conteúdo da cadeia de caracteres substituindo,
// inserindo ou removendo partes (Replace(), Insert(), Remove())

// Métodos que transformam uma cadeia de caracteres em uma matriz de cadeias de
// caracteres ou de caracteres (Split(), ToCharArray())


