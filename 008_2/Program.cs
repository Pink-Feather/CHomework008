// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

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

int MinRow(int[,] result)
{
    int sum = 0; //можно как вариант что sum = minValue - как самый малый элемент 
    int count = 0;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < result.GetLength(1); j++)
        {
            temp += result[i, j];
        }
        if (temp < sum)
        {
            sum = temp;
            count = i;
        }
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите количнство строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количнство столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] matrix = GetArray(row, col, 0, 100);
PrintArray(matrix);
Console.WriteLine();

Console.WriteLine($"Строка с наименьшей суммой элементов: {MinRow(matrix)}");