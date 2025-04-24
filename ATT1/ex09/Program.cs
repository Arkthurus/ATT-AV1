/* Gere um número aleatório entre 1 e 100. Peça que o usuário tente adivinhar. Após cada
tentativa, informe se o número é maior ou menor. Conte o número de tentativas */
int num = new Random().Next(2, 100); // Entre 1 e 100: Maior que 1 e menor que 100
int adivinhado = 0;

Console.WriteLine("Estou pensando em um número entre 1 e 100. Tente adivinhar qual e eu direi se meu número é maior ou menor!");

do
{
    Console.WriteLine("Qual é o número?");
    adivinhado = int.Parse(Console.ReadLine() ?? "0");

    if (adivinhado <= 1 || adivinhado >= 100) {
        Console.WriteLine("O número que estou pensando é maior que 1 e menor que 100!");
        continue;
    }

    if (adivinhado < num) {
        Console.WriteLine("Meu número é maior que esse!");
        continue;
    }

    if (adivinhado > num) {
        Console.WriteLine("Meu número é menor que esse!");
    }
} while (num != adivinhado);

Console.WriteLine($"Parabéns. Você acertou! Meu número era o {num}.");
