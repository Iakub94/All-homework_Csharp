// Задача 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();








// Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

int SumDigits (int number)
{
    int sum = 0;
    while (number <= 0)
    {
        sum += number;
        number--;
    }
    return sum;
}

Console.WriteLine("Input number: ");

int number = Convert.ToInt32(Console.ReadLine());
int result = SumDigits(number);

Console.WriteLine($"Sum of numbers is {result}");















// Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.