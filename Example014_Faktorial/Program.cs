
// int Factorial(int n)
// {
//     if (n == 0) return 1;
//     else return n * Factorial(n - 1);
// }
// Console.WriteLine(Factorial(3)); //3*2*1

double Factorial(int n)
{
    if (n == 0) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i<40; i++)
{
Console.WriteLine($"{i}! = {Factorial(i)}");
}

