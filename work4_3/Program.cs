// Мы потренируем то, каким образом можно взять,
// например, метод, передать в него массив 
//и заполнить массив нужным количеством элементов.

// На следующем этапе опишем метод, который будет
// выводить все элементы по порядку. 

////Затем превратим наш код поиска нужного индекса в метод

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index]=new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(coll[position]);
        position++;
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length; // переменная равна длине массива
    int index = 0;            // переменная  индекса элементов со значальным значением "0"
    int position = -1;          // переменная для записи номера искомого индекса, если выдаст значение -1, то искомого элемента в массиве нет 
    while (index<count)
    {
        if (collection[index]==find)  //условие цикла
        {
            position = index;   //действие при выполнении условия
            break;                  // Останока поиска
        }
        index++;        // увеличение индекса на 1 для перехода на след итерацию
    }
    return position;
}



int[]array = new int[10];   // Создать массив array из 10 элементов
FillArray(array);          // Наполнить массив array методом FillArray

array[6]= 4;               // принудительное введение значения 4 в элемент массива с индексом 6
PrintArray(array);         //Вывести массив array методом PrintArray 

Console.WriteLine();
int pos = IndexOf(array, 4); // задать переменную pos для индекса искомого элемента и рассчитать ее методом IndexOf из массива array, значение элемента  равно 4
Console.WriteLine(pos);      // вывести значение искомого индекса заданного значения элемента массива