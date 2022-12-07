// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Вводим первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вводим второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вводим третье число: ");
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    if (numberA > numberC)
    {
        Console.WriteLine("Максимальное число: " + numberA);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + numberC);
    }
}

else if (numberB > numberC)
{
    Console.WriteLine("Максимальное число: " + numberB);
}
else
{
    Console.WriteLine("Максимальное число: " + numberC);
}
