// Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
Console.Clear();

int[] CreatRandomArray(int size, int minValue, int maxValue) 
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000); 

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Array[{i+1}]is {array[i]}");
    }
} 

int Digits(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            Console.WriteLine("Четное число в массиве:" + array[i]);
        }
    }
    return quantity;
}

Console.Write("Введите количество элементов:");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение:");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение:");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRandomArray(size, min, max);
ShowArray(myArray);

int result = Digits(myArray);
Console.WriteLine(result);
*/

// Задача 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.Clear();

int[] CreatRandomArray(int size, int minValue, int maxValue) 
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue); 

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Array[{i+1}]is {array[i]}");
    }
} 

int Ne4etElement (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0) sum = sum + array[i];
    }
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreatRandomArray(size, min, max);
ShowArray(myArray);

int result = Ne4etElement(myArray);
Console.WriteLine(result);
*/

// Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
Console.Clear();

double[] CreatRandomArray(int size, int maxValue) 
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().NextDouble() * maxValue; 
    return array;   
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i+1}]is {array[i]}");
    }
} 

double DifMinMax (double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];
        if(array[i] > max) max = array[i];
    }
    Console.Write("max " + max + " - min " + min + " = ");
    return max - min;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreatRandomArray(size, max);
ShowArray(myArray);

Console.WriteLine(DifMinMax(myArray));
*/
