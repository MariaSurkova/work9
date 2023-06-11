//Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// NaturalToLow(number, count);
// void NaturalToLow(int n, int count)
// {
//     if (count > n)
//     {
//         return;
//     }
//     else
//     {
//         NaturalToLow(n, count + 1);
//         Console.Write(count +" ");
//     }
// }

//Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.

// void Get(int m, int n)
// {
//     if (m < n)
//     {
//         Get(m + 1, n);
//         Console.Write(m);
//     }
//     else if (n < m)
//     {
//         Get(m, n + 1);
//         Console.Write(n);
//     }
//     else Console.Write(n);
// }
// Get(4, 7);

// Напишите программу вычисления функции 
// Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int Funk(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return Funk(m - 1, 1);
//     else return Funk(m - 1, Funk(m, n - 1));
// }
// Console.Write($"Итог {Funk(m, n)} ");