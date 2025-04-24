/*Solicite o peso (kg) e altura (m) do usuário, calcule o IMC e informe a classificação:
    • Abaixo de 18.5: Abaixo do peso
    • 18.5 a 24.9: Peso normal
    • 25 a 29.9: Sobrepeso
    • 30 ou mais: Obesidade */
namespace Cálculo_de_IMC_com_Classificacão
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Insira seu peso, em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine($"Insira sua altura, em m: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.Write("Você está ");
            if (imc < 18.5)
            {
                Console.WriteLine($" abaixo do peso.");
            }
            else if (imc <= 24.9) {
                Console.Write(" com o peso normal.");
            }
            else if (imc <= 29.9) {
                Console.Write(" com sobrepeso.");
            }
            else {
                Console.Write(" com obesidade.");
            }
        }
    }
}