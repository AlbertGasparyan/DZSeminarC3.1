// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine()??"0");

if(number>99 && number<999)
{
    int result=(number/10) %10;
    Console.WriteLine($"В числе {number} вторым симоволом является - {result}");
}
else
{
    Console.WriteLine($"Число {number} не явлеяется трёхзначным числом");
}