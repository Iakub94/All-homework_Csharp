// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.Clear();

Console.Write("Введите число А: ");
int numA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число В: ");
int numB = Convert.ToInt32(Console.ReadLine());

int step = 1;
for (int i = 0; i < numB; i++)
{
    step = step * numA;    
}

Console.WriteLine("A в степени B равно: " + step);
*/

// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.Clear();

int SumDigits (int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number;
        number--;
    }
    return sum;
}

Console.Write("Input number: ");

int num = Convert.ToInt32(Console.ReadLine());
int result = SumDigits(num);

Console.WriteLine($"Sum of numbers is {result}");
*/

// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
Console.Clear();

   int[] CreatRandomArray(int size) 
{
    int[] array = new int[8];

    for (int i = 0; i < array.Length; i++)
       {
            Console.Write($"Введите элемент массива под индексом {i}: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
       }

    return array;
}

    void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i+1}]is {array[i]}");
    }
} 

int size = 8;

int[] myArray = CreatRandomArray(size);
ShowArray(myArray);
*/

