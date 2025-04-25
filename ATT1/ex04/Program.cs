class Program
{
    static void Main()
    {
        int opcao = 0;
        while (opcao != 3)
        {
            Console.WriteLine("Menu de Conversão de Temperaturas:");
            Console.WriteLine("1- Celsius para Fahrenheit");
            Console.WriteLine("2- Fahrenheit para Celsius");
            Console.WriteLine("3- Sair");
            Console.Write("Escolha uma opção: ");
            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite a temperatura em Celsius: ");
                        if (double.TryParse(Console.ReadLine(), out double celsius))
                        {
                            double fahrenheit = (celsius * 9 / 5) + 32;
                            Console.WriteLine($"{celsius}°C equivalem a {fahrenheit:F2}°F\n");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.\n");
                        }
                        break;
                    case 2:
                        Console.Write("Digite a temperatura em Fahrenheit: ");
                        if (double.TryParse(Console.ReadLine(), out double fahrenheitInput))
                        {
                            double celsiusResult = (fahrenheitInput - 32) * 5 / 9;
                            Console.WriteLine($"{fahrenheitInput}°F equivalem a {celsiusResult:F2}°C\n");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Por favor, insira um número válido.\n");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Saindo");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, insira um número.\n");
            }
        }
    }
}
