/*Peça ao usuário 10 números e armazene em um array. Depois, calcule a soma apenas
dos números pares*/

namespace Soma_de_Números_Pares_de_Um_Array
{
    class Program
    {
        public static void Main(string[] args)
        {
            var nums = new int[10];
            var soma = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"[{i}] Insira um número: ");
                var lido = nums[i] = int.Parse(Console.ReadLine() ?? "0");

                if (lido % 2 == 0)
                {
                    soma += lido;
                }
            }

            Console.WriteLine($"A soma dos números pares inseridos é de {soma}.");
        }
    }
}