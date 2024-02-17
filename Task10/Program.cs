
int a=Convert.ToInt32(Console.ReadLine());

int Fib(int a)
{
    if (a==0 || a==1){
        return a;
    }
    else {
       return Fib(a-1)+Fib(a-2);
        
    }
}
for (int i=0; i<a; i++)
{
    System.Console.Write(Fib(i)+" ");
}
