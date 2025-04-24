Console.WriteLine("Informe um numero para ser fatorado:");
int n = int.Parse(Console.ReadLine());
int fat = 1;
int i=0;
while(i < n)
{
    fat*=(i+1);
    i++;
}
Console.WriteLine($"{n}! é = {fat}");
