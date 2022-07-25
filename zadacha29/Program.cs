// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] getArray(int mLocal)
{
    int[] result = new int[mLocal];
    Console.WriteLine("введите восемь элементов массива");
    for (int j = 0; j < mLocal; j++)
    {
/*для рандомной генерации элементов:
        result[j] = new Random().Next(0, 999);*/
/*для ввода с клавиатуры:*/
        result[j] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}

void printArray(int[] inArray)
{
    Console.Write($"[ ");
    for (int j = 0; j < inArray.GetLength(0); j++)
    {
        Console.Write($"{inArray[j]} ");
    }
    Console.Write($"]");
}

int size = 8;
printArray(getArray(size));