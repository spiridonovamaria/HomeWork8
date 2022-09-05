// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int row1 = Prompt("Введите количество строк первой матрицы: "),
    column1 = Prompt("Введите количество столбцов первой матрицы: "),
    row2 = Prompt("Введите количество строк второй матрицы: "),
    column2 = Prompt("Введите количество столбцов второй матрицы: ");
int[,] arr1 = ArrayFill(row1,column1);
ArrayPrint(arr1, "Первый массив чисел: ");
int[,] arr2 = ArrayFill(row2, column2);
ArrayPrint(arr2, "Второй массив чисел: ");
int[,] result = TwoMatrixProduct(arr1,arr2);
ArrayPrint(result, "Результирующая матрица: ");




int Prompt(string message)      
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    if (result < 1 && result > 9)
        throw new Exception("Это очень сложно :) Может попроще число попробуем?)");
    else
        return result;
}
int[,] ArrayFill(int rows, int columns)      
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
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
int[,] TwoMatrixProduct(int[,] arrayFirst, int[,] arraySecond)     
{
    int[,] arr1 = arrayFirst;
    int[,] arr2 = arraySecond;
    int[,] result = new int[row1,column2];
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < column2; j++)
        {
            for (int m = 0; m < column1 && m<row2; m++)
            {
                result[i,j] += arrayFirst[i,m] * arraySecond[m,j];
            }
        }   
    }
    return result;
    
}