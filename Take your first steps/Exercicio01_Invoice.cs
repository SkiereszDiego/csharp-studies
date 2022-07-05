# Exercício – Sequências de escape de caractere e cadeias de caracteres textuais
# Suponha que o seu gerente tenha pedido que você crie um modelo de uma ferramenta
# de linha de comando que vai gerar faturas em inglês e em japonês. Você não precisa
# criar a funcionalidade real que gera as faturas ainda. Você só precisa fornecer a
# interface do usuário da linha de comando para clientes internos no departamento
# de cobrança para aprovação. Seu gerente pediu para você ter certeza de que adicionou
# formatação para tornar claro o progresso atual da ferramenta. Seu gerente também
# pediu para fornecer instruções para os usuários japoneses sobre como gerar faturas
# em japonês.

Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");

// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
Console.WriteLine(@"c:\invoices\app.exe -j");

// Criar uma instância de uma classe
// Uma instância de uma classe é chamada de um objeto. Para criar uma instância de uma classe,
// use o operador new
Random dice = new Random();
O operador new faz várias coisas importantes:

// O operador new, primeiro, ele solicita um endereço na memória do computador grande o suficiente para armazenar um novo
// objeto com base na classe Random.
// Ele cria o objeto e o armazena no endereço de memória.
// Ele retorna o endereço de memória para que ele possa ser salvo na variável dice.
// Para chamar métodos de uma classe na Biblioteca de Classes do .NET, use o formato ClassName.MethodName()
