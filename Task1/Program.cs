int EvenCount(int a)
{
    int cnt=0;
    for (int i=a; i>0; i/=10)
    {
        if(i%10%2==0)cnt++;
    }
    return cnt;
}
int Odd(int a)
{
    int cnt2=0;
    for (int i=a; i>0; i/=10)
    {
        if(i%10%2!=0)cnt2++;
    }
    return cnt2;
}
int Zero(int a)
{
    int cnt3=0;
    for (int i=a; i>0; i/=10)
    {
        if(i%10==0)cnt3++;
    }
    return cnt3;
}
int Diggits(int a)
{
    int cnt4=0;
    for (int i=a; i>0; i/=10)
    {
        cnt4++;
    }
    return cnt4;
}
int Min(int a)
{
    int min=999999;
    for (int i=a; i>0; i/=10)
    {
        if(i%10<min)min=i%10;
    }
    return min;
}
int Max(int a)
{
    int max=-999999;
    for (int i=a; i>0; i/=10)
    {
        if(i%10>max)max=i%10;
    }
    return max;
}
int Sum(int a)
{
    int sum=0;
    for (int i=a; i>0; i/=10)
    {
        sum=sum+i%10;
    }
    return sum;
}

int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Even:{EvenCount(a) }");
System.Console.WriteLine($"Odd:{Odd(a)}");
System.Console.WriteLine($"Zeros:{Zero(a)}");
System.Console.WriteLine($"Digits{Diggits(a)}");
System.Console.WriteLine($"Min:{Min(a)}");
System.Console.WriteLine($"Max:{Max(a)}");
System.Console.WriteLine($"Sum of Digits:{Sum(a)}");
