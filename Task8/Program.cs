
void Function(int a, char c, int b)
{
    if (c =='+')System.Console.WriteLine($"{a} + {b} = {a+b}");
    if (c =='=')System.Console.WriteLine($"{a} - {b} = {a-b}");
    if (c =='/')System.Console.WriteLine($"{a} / {b} = {a/b}");
    if (c =='*')System.Console.WriteLine($"{a} * {b} = {a*b}");
}
int a=Convert.ToInt32(Console.ReadLine());
char c=Convert.ToChar(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());

Function(a,c,b);