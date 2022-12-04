// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
	
int result = SumNum(num);

int SumNum(int input)
{
int sum = 0;
while(input > 0)
    {
    sum = sum + input%10;   //sum += input % 10; 
    input = input /10;    
    }
return sum;
}

Console.WriteLine("Сумма цифр в числе = " +result);
