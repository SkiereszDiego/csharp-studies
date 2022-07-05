// Suponha que trabalhamos para uma loja de lembranças em uma cidade universitária que vende camisetas,
// moletons e outros presentes com o logotipo e as cores da instituição. Um relatório mensal de vendas
// usa a descrição completa, assim como a SKU (Unidade de Manutenção de Estoque) dos produtos vendidos.
// Pediram que reescrevêssemos determinadas partes do código para ficarem mais legíveis.
// Uma das tarefas é simplificar a conversão de um SKU em uma descrição usando a instrução switch.
// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");