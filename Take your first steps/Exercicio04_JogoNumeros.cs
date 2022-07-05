// Usaremos o método Random.Next() para simular a rolagem de três dados de seis lados cada.
// Avaliaremos os valores para calcular a pontuação.Se a pontuação for superior a um total arbitrário,
// exibiremos uma mensagem de vitória para o usuário.
// Caso contrário, exibiremos uma mensagem de derrota para o usuário.

// Se quaisquer dois dados rolados resultarem no mesmo valor, você receberá dois pontos de bônus pelo resultado duplicado.
// Se os três dados rolados resultarem no mesmo valor, você receberá seis pontos de bônus pelo resultado triplicado.
// Se a soma dos três dados rolados, mais quaisquer pontos de bônus, for igual ou maior que 15,
// você vencerá o jogo. Caso contrário, você perderá.
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}