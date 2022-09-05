//  Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.



int[,] arr = ArrayFill();
ArrayPrint(arr, "Двумерный массив чисел: ");
int[,] result = ArraySort(arr);
ArrayPrint(result, "Отсортированный массив: ");


int[,] ArrayFill()    
{
    int[,] array = new int[4, 4];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-25, 25);
        }
    }
    return array;
}
void ArrayPrint(int[,] array, string description)        
{
    System.Console.WriteLine(description);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 0)
            {
                if (array[i, j] % 100 > 9)
                {
                    System.Console.Write(" " + array[i, j] + " ");
                }
                else
                {
                    System.Console.Write("  " + array[i, j] + " ");
                }
            }
            else
            {
                if (array[i, j] % 100 <= -10)
                {
                    System.Console.Write(array[i, j] + " ");
                }
                else
                {
                    System.Console.Write(" " + array[i, j] + " ");
                }
            }
        }
        System.Console.WriteLine();
    }
}
int[,] ArraySort(int[,] array)
{
    int[,] arr = array;
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            if (arr[i, j - 1] < arr[i, j])
            {
                temp = arr[i, j];
                arr[i, j] = arr[i, j - 1];
                arr[i, j - 1] = temp;
                j = 0;
            }
        }
    }
    return arr;
}