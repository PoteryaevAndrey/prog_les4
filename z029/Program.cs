// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] GetFilledArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(0, 101);
            }
            
            return array;
}

string PrintArray(int[] array)
{
    return String.Join(", ", array);
}

int[] mainArray = GetFilledArray (8);
Console.WriteLine(PrintArray(mainArray));
