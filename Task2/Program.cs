
char Check(int a)
{
    if (a>=90 && a<=100)return 'A';
    else if(a>=80 && a<=89)return 'B';
    else if (a>=70 && a<=79)return 'C';
    else if (a>=60 && a<=69)return 'D';
    else return 'F';
}
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{Check(a)}");