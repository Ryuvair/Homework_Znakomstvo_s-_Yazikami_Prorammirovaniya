Console.WriteLine("Введите длину чисел фибаначи");
int n = int.Parse(Console.ReadLine());

int Fib(int length)
{
    int[] array = new int[length];
    array[0] = 0;
    array[1] = 1;
    
    for(int i = 2; i < length; i++)
    {
        array[i]  = array[i-2] + array[i-1];
        
    }
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    }
    Console.WriteLine(" ");
    return 0;
}
Fib(n);