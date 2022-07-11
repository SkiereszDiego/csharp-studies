// Escreva o código necessário para inverter as letras de cada palavra no lugar
// e exibir o resultado. Em outras palavras, não basta inverter todas as letras
// na variável pangram. Em vez disso, você precisará inverter apenas as letras
// de cada palavra, mas imprimir a palavra invertida em sua posição original na
// mensagem.
// string pangram = "The quick brown fox jumps over the lazy dog";
string pangram = "The quick brown fox jumps over the lazy dog";

string[] message = pangram.Split(' ');
string[] newMessage = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

string result = String.Join(" ", newMessage);
Console.WriteLine(result);