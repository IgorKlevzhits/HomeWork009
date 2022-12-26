/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int getNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && (result > 0))
        {
            break;
        }
        else
        {
            Console.WriteLine($"Введено неверное число, повторить ввод");
        }
    }
    return result;
}

int getSumMN(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    else
    {
        return n + getSumMN(m, --n);
    }
}

int m = getNumber("Введите первое число: ");
int n = getNumber("Введите второе число: ");
if (m < n)
{
    Console.WriteLine($"Сумма чисел от {m} до {n} равно - {getSumMN(m, n)}");
}
else
{
    Console.WriteLine($"Сумма чисел от {n} до {m} равно - {getSumMN(n, m)}");
}