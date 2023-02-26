// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//произведением AB называется матрица  размера  m×n , элементы  которой вычисляются по правилу умножения 
// i-ой строки матрицы A на  j-ый столбец матрицы B

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

int[,] Multiplaction(int[,] massivA, int[,] massivB)
{
    int rowAmas = massivA.GetLength(0);
    int rowBmas = massivB.GetLength(0);
    int colAmas = massivA.GetLength(1);
    int colBmas = massivB.GetLength(1);

    int[,] multi = new int[rowAmas, colBmas];
    for(int i = 0; i < rowAmas; i++)
    {
        for (int j = 0; j < colBmas; j++)
        {
            for(int k = 0; k < rowBmas; k++)
            { 
                multi[i, j] += massivA[i, k] * massivB[k, j];
            }
        }
    }
    return multi;
}

Console.Clear();
Console.WriteLine("Введите количнство строк первой матрицы: ");
int rowA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количнство столбцов первой матрицы: ");
int colA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количнство строк второй матрицы: ");
int rowB = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количнство столбцов второй матрицы: ");
int colB = int.Parse(Console.ReadLine()!);

if (rowA != colB)
{
    Console.WriteLine("Умножение матриц не представляется возможным!");
    return;
}

int[,] matrixA = GetArray(rowA, colA, 0, 10);
PrintArray(matrixA);
Console.WriteLine();
int[,] matrixB = GetArray(rowB, colB, 0, 10);
PrintArray(matrixB);
Console.WriteLine();
PrintArray(Multiplaction(matrixA, matrixB));


