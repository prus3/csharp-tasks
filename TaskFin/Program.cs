// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.
// **Примеры**:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["01234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOutputArray = 0; // переменная при инициализации проекта
            int maxLenght = 3; // максимальная длина строки для выборки
            string[] inputArray = { "hello", "2", "world", ":-)" }; // пример для выборки
            PrintArray(inputArray);
            Console.Write(" -> ");
            string[] tempArray = new string[inputArray.Length];
            tempArray = SelectFromArray(inputArray, maxLenght);  // выборка во временный массив той же длины, что и входящий
            string[] outputArray = new string[sizeOutputArray];  // результирующий массив необходимой длины
            outputArray = TruncateArray(tempArray, sizeOutputArray);  // преобразуем в результирующий массив, убираем пустые элементы
            PrintArray(outputArray);


            string[] SelectFromArray(string[] inputArray, int length) // выборка в результирующий массив
            {
                string[] tempArray = new string[inputArray.Length];
                int j = 0;
                foreach (var item in inputArray)
                {
                    if (item.Length <= length)
                    {
                        tempArray[j++] = item;
                    }
                }
                sizeOutputArray = j;
                return tempArray;
            }

            string[] TruncateArray(string[] inputArray, int count) // чистка массива
            {
                string[] tempArray = new string[count];
                int i = 0;
                while (i < count) tempArray[i] = inputArray[i++];
                return tempArray;
            }

            void PrintArray(string[] array) //  вывод массива
            {
                Console.Write("[");
                int count = 0;
                while (count < array.Length)
                {
                    if (count < array.Length - 1) 
                    {
                        Console.Write($"\"{array[count]}\", ");
                    }
                    else
                    {
                        Console.Write($"\"{array[count]}\"");
                    }
                    count++;
                }
                Console.Write("]");
            }
        }
    }
}