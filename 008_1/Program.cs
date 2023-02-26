// Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) //бегает по строчкам и заполняет их
    {
        for (int j = 0; j < n; j++) //бегает по столбцам и заполняет их
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray) //функция которая печатает массив
{
     for (int i = 0; i < inArray.GetLength(0); i++) 
    {
        for (int j = 0; j < inArray.GetLength(1); j++) 
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine(); 
    }
}

void SortMassive(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int a = 0; a < array.GetLength(1) - 1; a++)
            {
                int temp;
                if (array[i, a] < array[i, a + 1])
                {
                    temp = array[i, a + 1];
                    array[i, a + 1] = array[i, a];
                    array[i, a] = temp;
                }
            }
        }
    }
}

Console.Clear();
Console.WriteLine("Введите количнство строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количнство столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] matrix = GetArray(row, col, 0, 10);
PrintArray(matrix);
Console.WriteLine();

SortMassive(matrix);
PrintArray(matrix);