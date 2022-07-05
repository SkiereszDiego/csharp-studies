# Imagine que você trabalha para uma fábrica e precisa fazer um inventário do depósito
# para determinar o número atual de produtos finais que estão prontos para o envio.
# Além do número total de produtos finais, você também pode querer imprimir uma contagem
# e o total atual de cada compartimento individual do depósito em que os produtos finais
# são armazenados. Imprimir esse total atual criaria uma trilha de auditoria para verificar
# novamente o trabalho e identificar reduções.

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");


// Anteriormente, decidimos escrever código para armazenar IDs de pedidos possivelmente fraudulentos.
// Esperamos encontrar pedidos fraudulentos o quanto antes e sinalizá-los para uma análise mais
// profunda.

// Nossa equipe detectou um padrão. Pedidos que começam com a letra "B" têm um número de fraudes 25
// vezes maior que o normal. Vamos escrever um novo código para gerar a ID de novos pedidos, em que
// a ID do pedido começa com a letra "B". Isso será usado por nossa equipe de fraudes para investigar
// ainda mais.

string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}