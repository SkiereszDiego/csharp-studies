// Comece digitando o nome de classe, Console
// Adicione o operador de acesso de membro, o símbolo .
// Adicione o nome do método, WriteLine
// Adicione o operador de chamada do método, que é um conjunto de parênteses ()
// Por fim, adicione o valor que você deseja que o método Console.WriteLine()
Console.WriteLine("Hello World!");

// Variable name examples

// char userOption;

// int gameScore;

// decimal particlesPerMillion;

// bool processedCustomer;


// Write a bool literal to the console
Console.WriteLine(true);
Console.WriteLine(false);

// Write an int literal to the console
Console.WriteLine(123);


// Write a decimal literal to the console
Console.WriteLine(12.3m);

// Reassign the value of a variable
string firstName = "Bob";
Console.WriteLine(firstName);
firstName = "Beth";
Console.WriteLine(firstName);

// implicitly typed local variables
// // An implicitly typed local variable is created using the var keyword,
//  which instructs the C# compiler to infer the type.
// Other programming languages use the var keyword differently.
// In C#, the variable is statically typed by the compiler regardless of
// whether you use the actual data type or allow the compiler to infer the data type.
//  In other words, the type is locked in at the time of declaration and therefore will
//  never be able to hold values of a different data type.
// You can only use the var keyword if the variable is initialized

string name = "Bob";
int messages = 3;
decimal temperature = 34.4m;

Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(temperature);
Console.Write(" celsius.");

// Sequências de escape de caractere
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"!");
// E se você precisar usar a barra invertida para outras finalidades, como exibir um caminho de arquivo?
// Para resolver o problema, use a \\ para exibir uma barra invertida simples.
Console.WriteLine("c:\\source\\repos");

// Formatar a saída do aplicativo de linha de comando usando sequências de escape de caractere
Console.WriteLine("Generating invoices for customer \"ABC Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

// Literal de cadeia de caracteres textual
// Para criar uma cadeia de caracteres textual, use a diretiva @ antes da cadeia de caracteres litera
Console.WriteLine(@"   c:\source\repos
      (this is where your code goes)");

// Caracteres de escape Unicode
// Você também pode adicionar caracteres codificados em cadeias de caracteres literais usando a sequência 
// de escape \u e, em seguida, um código de quatro caracteres representando algum caractere em Unicode (UTF-16).

// Kon'nichiwa World
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");

// Existem várias advertências. Primeiro, alguns consoles, como o prompt de comando do Windows, não exibirão
// todos os caracteres Unicode. Ele substituirá esses caracteres por caracteres de ponto de interrogação.
// Além disso, os exemplos usados aqui são UTF-16. Alguns caracteres exigem UTF-32 e, portanto, exigem uma
// sequência de escape diferente. Esse é um assunto complicado, e este módulo pretende apenas mostrar o que é
// possível. Dependendo de sua necessidade, talvez seja necessário gastar bastante tempo aprendendo e trabalhando
// com caracteres Unicode em seus aplicativos.


// Concatenar uma cadeia de caracteres
string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine(greeting + " " + firstName + "!");

// // interpolação de cadeia de caracteres
//  An interpolation expression is a variable surrounded by an opening and closing curly brace symbol { }.
//  The literal string becomes a template when it's prefixed by the $ character.

string firstName = "Bob";
string greeting = "Hello";
Console.WriteLine($"{greeting} {firstName}!");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

string projectName = "ACME";
string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");

// adicionar dois valores numéricos
string firstName = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets.");

// Para ver a divisão funcionando corretamente, precisamos usar um tipo de dados que dê suporte a dígitos
// fracionários após o ponto decimal, como decimal.
decimal decimalQuotient = 7 / 5.0m;
// ou
decimal decimalQuotient = 7.0m / 5.0m;
Console.WriteLine("Decimal quotient: " + decimalQuotient);
// Para que isso funcione, o quociente (à esquerda do operador de atribuição) deve ser do tipo decimale o
// dividendo ou o divisor deve ser do tipo decimal (ou ambos).

// Para converter int em decimal, você adiciona o operador de conversão antes do valor. Use o nome do tipo de
// dados entre parênteses na frente do valor para convertê-lo. Neste caso, adicionaríamos (decimal) antes das
// variáveis first e second.
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

// C# segue a mesma ordem que o acrônimo PEMDAS, exceto pelos exponentes. Embora não haja um operador com
// exponente em C#, você pode usar o método System.Math.Pow(),


// Incrementar e decrementar valores
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);
// No "segundo incremento", eu usei value += 1;, mas poderia ter usado qualquer valor de int literal
// (ou uma variável) para incrementar esse valor. se você usar o operador antes do valor,
// como em ++value, o incremento ocorrerá antes que o valor seja recuperado. Da mesma forma,
// value++ incrementará o valor após ele ser recuperado.
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine("Second: " + value++);
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

// Declarar uma nova matriz
// Observe que o primeiro conjunto de colchetes [] simplesmente indica ao compilador que a variável
// de nome fraudulentOrderIDs será uma matriz. No entanto, o segundo conjunto de colchetes [3]
// contém o número de elementos que a matriz conterá.

/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// loop em uma matriz usando o foreach
string[] names = { "Bob", "Conrad", "Grant" };
foreach (string name in names)
{
    Console.WriteLine(name);
}