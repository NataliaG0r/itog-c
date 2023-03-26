// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

metka:

System.Console.Write("Введите положительное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите положительное число M: ");
int m = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
{
    System.Console.WriteLine("числа не положительные, повторите ввод");
    goto metka;
}

if (n > 0 && m > 0)
    ;

{
    if (n > m)
    {
        int sum = 0;
        for (int i = m; i <= n; i++)
        {
            sum = sum + i;
        }
        System.Console.WriteLine(
            $"Сумма натуральных элементов в промежутке от {m} до {n} равна {sum}"
        );
    }
    else if (m >= n)
    {
        int sum = 0;
        for (int i = n; i <= m; i++)
        {
            sum = sum + i;
        }
        System.Console.WriteLine(
            $"Сумма натуральных элементов в промежутке от {n} до {m} равна {sum}"
        );
    }
}

// // // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// // //  Даны два неотрицательных числа m и n.
// // // m = 2, n = 3 -> A(m,n) = 9
// // // m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if ((numM != 0) && (numN == 0))
    {
        return Ackermann(numM - 1, 1);
    }
    else if ((numM != 0) && (numN != 0))
    {
        return Ackermann(numM - 1, Ackermann(numM, numN - 1));
    }
    else
    {
        return numN + 1;
    }
}

nachalo:
System.Console.Write("Введите положительное число N: ");
int n1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите положительное число M: ");
int m1 = Convert.ToInt32(Console.ReadLine());

if (m1 < 0 || n1 < 0)
{
    System.Console.WriteLine("числа не положительные, повторите ввод");
    goto nachalo;
}

int result = Ackermann(m1, n1);
Console.WriteLine($"Ackermann({m1}, {n1}) = {result}");
