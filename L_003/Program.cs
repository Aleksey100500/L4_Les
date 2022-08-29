/*double Factorial ( int n)
{
    if ( n == 1 ) return 1;
    else return n * Factorial(n - 1);
}

for(int i = 1; i < 40; i ++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}*/

double Fibonache(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonache(n-1) + Fibonache(n-2);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{Fibonache(i)}");
}