//  Um herói e um monstro começam com a mesma pontuação de integridade. Durante a rodada do herói,
//  ele gerará um valor aleatório que será subtraído da integridade do monstro. Se a integridade
//  do monstro for maior que zero, ela terá sua rodada e atacará o herói. Desde que tanto o herói
//  quanto o monstro tenham integridade maior que zero,a batalha continuará.
// Regras do Jogo

// O herói e o monstro começarão com dez pontos de integridade.
// Todos os ataques serão um valor entre 1 e 10.
// O herói atacará primeiro.
// Imprima a quantidade de integridade que o monstro perdeu e a integridade que resta a ele.
// Se a integridade do monstro for maior que zero, ele poderá atacar o herói.
// Imprima a quantidade de integridade que o herói perdeu e a integridade que resta a ele.
// Continue esta sequência de ataque até que a integridade do monstro ou do herói seja zero ou menos.
// Imprima quem foi o vencedor.
// O mais importante é:

// Você precisa usar a instrução do-while ou a instrução while.
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
