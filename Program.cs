// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

 metka:

 System.Console.Write("Введите положительное число N: ");
 int n = Convert.ToInt32(Console.ReadLine());
 System.Console.Write("Введите положительное число M: ");
 int m = Convert.ToInt32(Console.ReadLine());

 if (m<0||n<0)
 {
  System.Console.WriteLine("числа не положительные, повторите ввод");
  goto metka;
 }

 if (n>0&&m>0);
 {
     if (n > m)
     {
         int sum = 0;
         for (int i = m; i <= n; i++)
         {
             sum = sum + i;
         }
         System.Console.WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} равна {sum}");
     }
     else if (m >= n)
     {
         int sum = 0;
         for (int i = n; i <= m; i++)
         {
            sum = sum + i;
         }
         System.Console.WriteLine(
             $"Сумма натуральных элементов в промежутке от {n} до {m} равна {sum}");
     }
 }




// System.Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
//Sum(m, n);

// void Sum(int numM, int numN)
// {
// if (numM < numN)
// {
// return;
// }
// Sum(numM, numN + 1);
// System.Console.Write(numN + );
// }

// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// // M = 1; N = 5 -> "1, 2, 3, 4, 5"
// // M = 4; N = 8 -> "4, 6, 7, 8"

// System.Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Print(m, n);

// void Print(int numM, int numN)
// {
// if (numN < numM)
// {
// return;
// }
// Print(numM, numN - 1);
// System.Console.Write(numN + "\t");
// }





// }
// else
//  {
//  System.Console.Write("числа не являются положительными");
//  }
// goto metka;

// int[] GenerateArray(int minValue, int maxValue)
// {
//  int[] arr = new int[maxValue-minValue];

//   Random rand = new Random();

// for (int i = 0; i < arr.Length; i++)
// {
// arr[i] = rand.Next(minValue, maxValue + 1);
// }
// return arr;
// }

// void PrintArray(int[] arr)
// {
// System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
// }

// var array = GenerateArray(1, 15);


// PrintArray(array);


// // Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// // 453 -> 12
// // 45 -> 9

//  int GenerateNum(M)

//  {Random rand = new Random();
// int num = rand.Next(1, 16);
//  }

// int M =GenerateNum(M);
// System.Console.WriteLine($"Случайное число: {M}");

// // //     int a = new int[size];
// // //     var rand = new Random();
// // //     for (int i = 0; i < array.Length; i++)
// // //     {
// // //         array[i] = rand.Next(leftRange, rightRange + 1); // -9, 9 + 1
// // //     }
// // //     return array;
// // // }

// // System.Console.Write("Введите число N: ");
// // int n = Convert.ToInt32(Console.ReadLine());
// // System.Console.WriteLine(Summ(n, 0));

// // int Summ(int num, int sum)
// // {
// // sum += num % 10;
// // if (num < 10)
// // {
// // return sum;
// // }
// // return Summ(num / 10, sum);
// // }

// // int ReadInt(string text)
// // {
// // System.Console.Write(text);
// // return Convert.ToInt32(Console.ReadLine());
// // }

// // int Power(int n, int m)
// // {

// // if (m == 1)
// // return n;

// // return n * Power(n, m--);

// // }

// // int n = ReadInt("Введите N: ");
// // int m = ReadInt("Введите M: ");


// // System.Console.WriteLine(Power(n, m));



// // // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// // //  Даны два неотрицательных числа m и n.
// // // m = 2, n = 3 -> A(m,n) = 9
// // // m = 3, n = 2 -> A(m,n) = 29

// If m=0
// {
//     A=n+1;
// }
// Else If m>0&n==0
// {A=(m-1,1)}
// Else if m>0&n>0
// {A(m-1, A(m,n-1))}

// int A(int n, int m)
// {
//   if (n == 0)
//     return m + 1;
//   else
//     if ((n != 0) && (m == 0))
//       return A(n - 1, 1);
//     else
//       return A(n - 1, A(n, m - 1));
// }