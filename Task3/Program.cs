
int n=int.Parse(Console.ReadLine());
int []arr = new int[n];
for (int i=0; i<n; i++)
{
     arr[i]=Convert.ToInt32(Console.ReadLine());
}
int neg=0, pos=0, zer=0, eve=0, odd=0, max=-9999999, min=9999999, sum=0;
for (int i=0; i<n; i++)
{
    if (arr[i]<0)neg++;
    else if (arr[i]>0)pos++;
    else if (arr[i]==0)zer++;
}
for (int i=0; i<n; i++)
{
    if (arr[i]%2==0)eve++;
    if (arr[i]%2!=0)odd++;
}
for (int i=0; i<n; i++)
{
    if (arr[i]>max)max=arr[i];
     if (arr[i]<min)min=arr[i];
    
}
for (int i=0; i<n; i++)
{
    sum=sum+arr[i];
}
System.Console.WriteLine($"Negative = {neg}");
System.Console.WriteLine($"Positive = {pos}");
System.Console.WriteLine($"Zeros = {zer}");
System.Console.WriteLine($"Even = {eve}");
System.Console.WriteLine($"Odd = {odd}");
System.Console.WriteLine($"Max = {max}");
System.Console.WriteLine($"Min = {min}");
System.Console.WriteLine($"Sum of Digits = {sum}");