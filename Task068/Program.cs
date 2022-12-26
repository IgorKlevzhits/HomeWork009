/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

uint getNumber(string message)
{
    uint result = 0;
    while (true)
    {
        Console.Write(message);
        if (uint.TryParse(Console.ReadLine(), out result) && (result > 0))
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

uint A(uint m, uint n)
{
    if (m == 0)
        return n + 1;
    else
      if ((m != 0) && (n == 0))
        return A(m - 1, 1);
    else
        return A(m - 1, A(m, n - 1));
}

uint m = getNumber("Введите первое число: ");
uint n = getNumber("Введите второе число: ");
Console.WriteLine($"A({m}, {n}) = {A(m, n)}");