// escopo de variável
bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside of code block: {value}");
}

// Se quisermos acessar a variável value fora do bloco de código da instrução if?
bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine("Outside of code block: " + value);

// -=-=-=-=-=-=-=-=--=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
using System;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

// Método é um bloco de código que é uma unidade de execução.
// Em outras palavras, depois que o método for chamado pelo respectivo nome,
// o método inteiro será executado

// Quando o programa for executado, por padrão, o tempo de execução do .NET pesquisará
// por um método chamado Main() para usar como ponto de partida ou ponto de entrada
// para o programa.
// Uma classe é um contêiner para membros como métodos, propriedades, eventos,
// campos e assim por diante.
// Um namespace realiza a desambiguação de nomes de classe.Você pode criar namespaces adicionais
// em seu código conforme necessário e criar uma série hierárquica de namespaces usando o operador ponto.

namespace MyNewApp.Business
{
  // Classes here    
}

// Podemos adicionar quantos namespaces quisermos. Podemos criar namespaces com qualquer número de níveis de
// profundidade que for necessário. Continuaríamos simplesmente acrescentando nomes de namespace filho usando
// o operador ponto.

// Chamar um método na mesma classe
// Já que o método Reverse() é definido na mesma classe, o código que chama o método não precisa qualificar o nome do
// método com o nome de classe.
using System;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }

        static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}

// Chamar um método de uma classe diferente
// Já que o método não "vive" mais na mesma classe, para chamar o método Reverse(),
// precisamos acessá-lo por meio da classe para a qual ele foi movido.

using System;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }

    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}

// Referenciar uma classe em um namespace diferente

using System;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = MyNewApp.Utilities.Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }
}

namespace MyNewApp.Utilities
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}

// A instrução using
// A instrução using é adicionada à parte superior de um arquivo de código.
// Ela resolve os nomes de classe que são usados no arquivo, instruindo o
// compilador a examinar a lista de namespaces para localizar todos os nomes de classe.
// A instrução using informa ao compilador para procurar aqui ao tentar resolver quaisquer
// nomes de classe que ele precise localizar. Agora, podemos chamar o método Reverse() usando
// apenas o nome de classe, da seguinte forma:
using System;
using MyNewApp.Utilities;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }
}

namespace MyNewApp.Utilities
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}
// Também é por isso que o modelo que gera o arquivo Program.cs inclui essa linha de código na parte superior
using System;
// Isso possibilita chamar Console.WriteLine() em vez de System.Console.WriteLine().

// gravar outras instruções if e else sem blocos de código
string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");

// Métodos que retornam um valor booliano
// Alguns tipos de dados têm métodos que executam tarefas de utilitário bastante úteis.
// O tipo de dados String tem muitos deles. Vários retornam um valor booliano incluindo Contains(),
// StartsWith() e EndsWith(). Você pode aprender mais sobre eles no módulo do Microsoft Learn
// "Manipular dados alfanuméricos usando métodos da classe String no C#".
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));