// Найти первую и вторую цифру слкйчаного двухзначного числа, найти больше
// и меньшее


int RandomNumber = 11; //new Random().Next(10,100);

Console.Write("Случайное число : ");
Console.WriteLine(RandomNumber);

int MaxDigit(int arg)
{
int FirstDigit = arg / 10;
int SecondDigit = arg % 10;

if ( FirstDigit == SecondDigit )
{
        Console.Write("Первая и вторая равны");
        return 0;
}

if (FirstDigit > SecondDigit)
{
    Console.Write("Наибольшей цифрой является первая :");
    Console.WriteLine(FirstDigit);    

}
else
    {
        Console.Write("Наибольшей цифрой является вторая :");
        Console.WriteLine(SecondDigit);   
    }
return 0;
    }
MaxDigit(RandomNumber);