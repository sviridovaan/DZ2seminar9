//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();
int EnterNumber(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int M = EnterNumber("Введите натуральное число M");
int N = EnterNumber("Введите натуральное число N");

int SumNumbers(int min, int max)
{
    if (min == max)
    {
        return min;
    }
    else 
    {
        return SumNumbers(min, max - 1) + max;
    }
}
Console.WriteLine(SumNumbers(M, N));