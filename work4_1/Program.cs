// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A для возведения в степень");
double A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень N для числа A");
int N = Convert.ToInt32(Console.ReadLine());
double res=1;
if (N<0)
Console.WriteLine("Число N может быть равно 0 или быть целым положительным");
else
{
for (int i = 1; i <= N; i++)
    {
    res=res*A;
    }
Console.WriteLine("Число "+A+" в степени "+N+" равно "+res);
}

//int GetStepenNum (int res);