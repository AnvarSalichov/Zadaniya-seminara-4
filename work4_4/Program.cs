// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[]array = new int[8];   
// FillArray(array);          
// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index]=new Random().Next(1,100);
//         index++;
//     }
// }
// Console.Write(String.Join(", ", array));
// Console.WriteLine();

int [] array = new int [8];
GetArray(array);
void GetArray(int [] massiv)
{
	for (int i = 0; i <massiv.Length; i++)
	{
	    massiv[i] = new Random().Next(0,100);
	}
}
Console.Write(String.Join(", ", array));
Console.WriteLine();


 

