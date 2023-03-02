int Searchforsquares(int arg)
{
    double ans = 0;

    for (int i = 1; i <= arg; i++)
    {
        ans = Math.Pow(i,2);
        Console.Write(i);
        Console.Write(" в квадрате : ");
        Console.WriteLine (ans);
    }
return 0 ;
}

Console.Write("Введите число : ");
int N = int.Parse(Console.ReadLine());

Searchforsquares(N);

