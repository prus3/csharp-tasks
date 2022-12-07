// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Вводим первое число  ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вводим второе число  ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine(numberA + " > " + numberB);
}
else if (numberB > numberA)
{
    Console.WriteLine(numberB + " > " + numberA);
}
else
{
    Console.WriteLine(numberB + " = " + numberA);
}
