Console.WriteLine("Informe o nuemro da tabuada que deseja ver:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("-----------------------------");

for (int i = 0; i < 10; i++)
{
    int mod = num*(i+1);
    Console.WriteLine($"{num} x {i+1} = {mod}");
}