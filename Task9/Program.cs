int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int sum=1;
for (int i=0; i<b; i++)
{
    sum*=a;
}
System.Console.WriteLine($"The value of {a} to the power of {b} is : {sum}");