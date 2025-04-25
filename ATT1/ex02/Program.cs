Console.WriteLine("Informe o numero da tabuada que deseja ver:"); // Pede ao usuário um input
int num = int.Parse(Console.ReadLine()); // Atribui o input do usuário para a variável "num", do tipo inteiro
Console.WriteLine("-----------------------------"); // Separador de linhas para fins de embelezamento do output

for (int i = 0; i < 10; i++) // Loop que itera dez vezes (de 0 a 9)
{
    int mod = num*(i+1); // Realiza a operação da tabuada equivalente ao número atual da iteração + 1
			 // (Se "i" for igual a 0, será feito o cálculo de num * (i + 1), ou seja, num * 1)
			 // O resultado é, então, atribuído à variável "mod"
    Console.WriteLine($"{num} x {i+1} = {mod}"); // Imprime o resultado guardado em "mod"
						 // Tendo-se num=3 e i=2, o output seria:
						 // 3 x 3 = 9
}

// No fim, o resultado esperado é o de todas as operações de multiplicação de um número "num" de 1 até 10, inclusive
