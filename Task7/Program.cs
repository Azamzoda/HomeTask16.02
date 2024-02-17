
int x=Convert.ToInt32(Console.ReadLine());
int y=Convert.ToInt32(Console.ReadLine());
for (int i=x; i<=y; i++)
{
    System.Console.WriteLine($"______________");
    System.Console.WriteLine();
    for (int j=1; j<11; j++)
    {
        System.Console.WriteLine($"{i} * {j} = {i*j}");
    }
}