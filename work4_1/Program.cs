// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число для возведения в степень");
double A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int B = Convert.ToInt32(Console.ReadLine());

double Stepennum(double A, int B)
{
    double result = 1;
    for (int i = 1; i <= B; i++)
    {
    result=result*A;
    }
    return result;
}

double result = Stepennum(A, B);

Console.WriteLine("Число "+A+" в степени "+B+" равно "+result);
